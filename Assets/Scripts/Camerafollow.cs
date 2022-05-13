using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public GameObject ballsphere; //this creates a gameobject in the inspector file of the charcacter this script is attached to
    //I will have to drag my character in the gameobject box

    private Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - ballsphere.transform.position; //distanta dintre camera si minge trebuie sa fie constanta

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = distance + ballsphere.transform.position; //updatam pozitia mingiei si in acest mod tinem si distanta fata de camera constanta as long as the ball moves
        
    }
}
