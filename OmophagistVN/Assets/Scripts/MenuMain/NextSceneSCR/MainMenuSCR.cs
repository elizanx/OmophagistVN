using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSCR : MonoBehaviour
{
   public void Play() 
    {
        SceneManager.LoadScene("(2)Cutscene");
    }

    public void Quit()
    {
        Application.Quit();
        
    }
}
