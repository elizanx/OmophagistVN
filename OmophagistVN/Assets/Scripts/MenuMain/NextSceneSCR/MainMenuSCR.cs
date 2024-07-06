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

    public void GoToRebellionsNight()
    {
        SceneManager.LoadScene("RebellionNight");
    }


    //Scene: RebellionNight
    public void GoToRebellionPrepare()
    {
        SceneManager.LoadScene("RebellionPrepare");
    }


    //Scene: RebellionPrepare
    public void GoToTheWayToLycaon()
    {
        SceneManager.LoadScene("TheWayToLycaon");
    }

    //Scene: TheWayToLycaon
    public void GoToFakeVictory()
    {
        SceneManager.LoadScene("Victory...OrNot");
    }


    //Scene: BadEnding
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("(1)MainMenu");
    }
    
    public void Quit()
    {
        Application.Quit();
        
    }

   
}
