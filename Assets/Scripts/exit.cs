using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
   public void exitgame()
    {
        Debug.Log("u pressed the exit button");
        Application.Quit();//it basically exists your game
        //I can't test the exit button, bc i'm inside unity and play
        //so I use the Debug.Log to test it, which shows me a message when exit is pressed
    }
}
