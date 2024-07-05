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

    public void GoToTesting() 
    {
        SceneManager.LoadScene("(3)TestingLoading");
    }

    
    public void Prologue()
    {
        SceneManager.LoadScene("Dialogue");
    }








    //Scene: RebellionStart
    public void GoToRebellionStart()
    {
        SceneManager.LoadScene("RebellionStart");
    }

    public void OnCanvasGroupChanged()
    {
        SceneManager.LoadScene("RebellionNight");
    }



    public void Quit()
    {
        Application.Quit();
        
    }

   
}
