using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PauseTheGame()
    {
        Debug.Log("De game staat op pauze");
        Time.timeScale = 0;
    }


    public void ResumeTheGame()
    {
        Debug.Log("De game gaat verder");
        Time.timeScale = 1;
    }
}
