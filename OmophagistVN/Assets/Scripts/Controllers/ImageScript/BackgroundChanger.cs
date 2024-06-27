using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Reflection;

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
    //if (SceneName == "(jouw scene naam)" && index == (natuurlijk bij welke zin jij het wilt) )
    // {
    //     Debug.Log("hoi");
    //     image.sprite = backgrounds[0];
    // }

    // Voorbeeld:
    // if (SceneName == (3)TestingLoading && index == 3)
    //  {
    //      Debug.Log("Dit is een voorbeeld");
    //      image.sprite = backgrounds[1];
    //  }

    // Ik maak hier een voorbeeld voor als je de knoppen in 2 scenes wilt hebben, maar wel anders wilt maken:
    //
    // Scene 1:
    // if (SceneName == (2)Cutscene && index == 5)
    // {
    //     Debug.Log("hoi");
    //     image.sprite = backgrounds[0];
    //     KnoppenAan();
    // }

    // Scene 2:
    // if (SceneName == (1)MainMenu && index == 2)
    // {
    //     Debug.Log("hoi");
    //     image.sprite = backgrounds[0];
    //     KnoppenAan();
    // }

    // Tip voor Joyce: 
    // index == 0 = index = eerste zin.

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
            Debug.Log("bgchange");
            image.sprite = backgrounds[0]; 
           

        }



        if (index == 3)
      {
            Debug.Log("Dit is de 3e zin");
            image.sprite = backgrounds[2];
            
        }

        if (index == 6)
      {
            Debug.Log("Dit is de 5e zin");
            image.sprite = backgrounds[2];
            KnoppenAan();

        }



        if (index == 7)
      {
            Debug.Log("Dit is de 6e zin");
            image.sprite = backgrounds[3];
            KnoppenUit();
        }
    }
}
