using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class BackgroundChanger : MonoBehaviour
{

    public List<Sprite> backgrounds;
    private Image image;
    private string SceneName;

    public GameObject Knop1;
    public GameObject Knop2;
    public GameObject Knop3;
    
    // Start is called before the first frame update
    void Start()
    {
        Dialogue.OnSentenceIncrement += ChangeBackground;
        image = GetComponent<Image>();
        SceneName = SceneManager.GetActiveScene().name;
        KnoppenUit();
        
    }

    // Update is called once per frame
    void Update()
    {

    }




    //Eliza, als je wilt dat het dus bij alle scene's anders is moet je gewoon dit erbij doen:
    //Normaal: if (SceneName == "(jouw scene naam)" && index == (natuurlijk bij welke zin jij het wilt) )
    // {
    //     Debug.Log("hoi");
    //     image.sprite = backgrounds[0];
    // }

    void KnoppenUit()
    {
      Knop1.gameObject.SetActive(false);
      Knop2.gameObject.SetActive(false);
      Knop3.gameObject.SetActive(false);
    }

    void KnoppenAan() 
    {
        Knop1.gameObject.SetActive(true);
        Knop2.gameObject.SetActive(true);
        Knop3.gameObject.SetActive(true);
    }


    



    void ChangeBackground(int index)
    {
        

      if ( index == 2)
      {
            Debug.Log("hoi");
            image.sprite = backgrounds[0];
            KnoppenAan();

        }



        if (index == 3)
      {
            Debug.Log("Dit is de 3e zin");
            image.sprite = backgrounds[2];
            KnoppenUit();
        }
    }
}
