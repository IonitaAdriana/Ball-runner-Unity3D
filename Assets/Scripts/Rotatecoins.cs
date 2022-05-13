using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatecoins : MonoBehaviour
{
    Vector3 turncoins; //my coin is a 3D object, so it rotates in a 3 axis dimension

    // Update is called once per frame
    void Update()
    {
        turncoins = new Vector3(45, 0, 0); //ma invart in jurul axei X, asa ca doar X != 0
        transform.Rotate(turncoins * Time.deltaTime); //fct predefinita din monobehaviour, care face un obiect sa se roteasca
        //deltaTime allows the coins to rotate smoothly
    }
}
