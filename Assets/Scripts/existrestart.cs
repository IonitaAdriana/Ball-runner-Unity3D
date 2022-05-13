using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class existrestart : MonoBehaviour
{
   public void restart()
    {
        SceneManager.LoadScene("Main scene");
    }

    public void exit()
    {
        Application.Quit();
    }
}
