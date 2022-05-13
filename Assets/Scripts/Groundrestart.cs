using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Groundrestart : MonoBehaviour
{
    void OnTriggerEnter() //basically when u fall down it restarts the game
    {
        SceneManager.LoadScene("Main scene");
    }
}
