using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Moveball : MonoBehaviour
{
    // Start is called before the first frame update
	
	Rigidbody rb; //creez un obiect rigidbody, pentru ca sfera este rigidbody
	public int ballspeed = 0;
	public int jumpspeed = 0;
	private bool istouching = true; //variabila in care retin daca mingea atinge platforma
									//mingea continua sa sara chiar daca este deja in aer, vreau sa nu se intample asta
	private int counter; //private bc I don't want to see it in the inspector file
	public Text cointext;
	public AudioSource asource;// I need to see those 2 inside the insepctor, so I can drag the gameobject "audio source" in asource
	public AudioClip aclip;// and the audio clip in the aclip
	
    void Start() //se executa la inceputul jocului
    {
        rb = GetComponent<Rigidbody>(); //selectez mingea
		counter = 13;
		cointext.text = "Coins: " + counter;
    }

    // Update is called once per frame
    void Update() //keeps on executing every frame
    {
		//we will create here movement of the ball with the keyboard
        float Hmove = Input.GetAxis("Horizontal"); //tin doua variabile pe  care le incarc cu poz pe orizontala/verticala
		float Vmove = Input.GetAxis("Vertical");
		Vector3 moveball = new Vector3(Hmove, 0.0f, Vmove); //tin in vector val celor 3 pozitii, z = 0 pt ca nu vreau sa ma misc in sus
        rb.AddForce(moveball * ballspeed); // am inm cu o variabila, deoarece aceasta imi va aparea in unity si o pot modifica acolo
		
		
		
		//!!!!Vector3 e o clasa predefinita de aici
		
		if ((Input.GetKey(KeyCode.Space)) && istouching == true)
		{
			Vector3 balljump = new Vector3(0.0f, 6.0f, 0.0f);
			//pt space, am nev ca x si z sa fie 0
			rb.AddForce(balljump * jumpspeed);
			
		}
		
		istouching = false;
	}
	
	private void OnCollisionStay(){
		istouching = true;
			
	}
	
	//!!! ca sa facem camera sa urmareasca personajul avem nevoie sa facem main camera sa fie copilul personajului
	//!!!! dar la sfera nu merge pt ca se roteste o data cu ea
	
	private void OnTriggerEnter(Collider other){ //sphere is the collider
		if (other.gameObject.CompareTag ("CoinTag")){//I select the coins by tag
			other.gameObject.SetActive(false);
			counter = counter - 1;
			cointext.text = "Coins: " + counter; //don't forget to drag the text inside the script in unity!!
			asource.PlayOneShot(aclip); //it plays an the audioclip in the audio source
			//the asource is like a speaker in which u play the aclip
		}

		if (counter == 0)
		{
			SceneManager.LoadScene("endscene");
		}
	}
		
}
