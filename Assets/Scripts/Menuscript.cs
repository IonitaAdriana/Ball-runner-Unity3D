using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changescene()
    {
        SceneManager.LoadScene("Main Scene");
    }

    //don't forget, when u create a scene to go on build settings-> arrange them in the order u want them to
    //pt evenimentul onclick( butoane) trebuie sa pui un game object acolo unde scrie none
    //in cazul asta am un obiect gol, care contine scriptul scenei
    //in script aka aici, am functia care imi schimba scena, iar butonul meu fix asta trb sa faca
    //deci o sa pot selecta i campul "No function" functia changescene
}
