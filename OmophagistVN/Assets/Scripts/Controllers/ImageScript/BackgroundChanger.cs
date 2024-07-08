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

        //Scene: BadEnding
        if (SceneName == "BadEnding")
        {
            image.sprite = backgrounds[0];
        }

        //Scene: FollowUpBadEnding
        if (SceneName == "BadEnding2")
        {
            image.sprite = backgrounds[0];
        }
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



        void EersteKnop()
        {
            Knop1.gameObject.SetActive(true);
        }

        void EersteKnopUit()
        {
            Knop1.gameObject.SetActive(false);
        }
        
        void TweedeKnopAan()
        {
            Knop2.gameObject.SetActive(true);
        }

        void TweedeKnopUit() 
        {
            Knop2.gameObject.SetActive(false);
        }


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


            if (SceneName == "Dialogue" && index == 2)
            {
                //Debug.Log("bgchange");
                image.sprite = backgrounds[0];

            }


            if (SceneName == "Dialogue" && index == 3)
            {
                //Debug.Log("Dit is de 3e zin");
                image.sprite = backgrounds[3];
                EersteKnop();
            }


            if (SceneName == "Dialogue" && index == 4)
            {
                Debug.Log("Zin 4/ Interactief button");
                image.sprite = backgrounds[2];
                EersteKnopUit();
            }


           


            //Scene: Keuze1
            if (SceneName == "Dialogue" && index == 9)
            {
                SceneManager.LoadScene("Keuze1");
            }

            if (SceneName == "Keuze1" && index == 0)
            {
                Debug.Log("Eerste keuze");
                image.sprite = backgrounds[0];
                TweedeKnopAan();
            }

            if (SceneName == "Keuze1" && index == 0)
            {
                Debug.Log("Eerste keuze");
                image.sprite = backgrounds[0];
                TweedeKnopUit();
            }



            if (SceneName == "Keuze1" && index == 5)
            {
                Debug.Log("Werkt dit?");
                image.sprite = backgrounds[0];
                EersteKnop();
            }

            if (SceneName == "Keuze1" && index == 6)
            {
                Debug.Log("Werkt dit?");
                image.sprite = backgrounds[0];
                EersteKnopUit();
            }

       
             //Scene: Keuze2
            if (SceneName == "Keuze1" && index == 7)
            {
                SceneManager.LoadScene("Keuze2");
            }

            if (SceneName == "Keuze2" && index == 11)
            {
                EersteKnop();
            }

            if (SceneName == "Keuze2" && index == 12)
            {
                EersteKnopUit();
            }


            //Scene: Keuze3
            if (SceneName == "Keuze2" && index == 12)
            {
                SceneManager.LoadScene("Keuze3");
            }

            if (SceneName == "Keuze3" && index == 22)
            {
                EersteKnop();
            }

            if (SceneName == "Keuze3" && index == 23)
            {
                EersteKnopUit();
            }

            //Scene: Keuze4
            if (SceneName == "Keuze3" && index == 24)
            {
                SceneManager.LoadScene("Keuze4");
            }

            if (SceneName == "Keuze4" && index == 1)
            {
                EersteKnop();
            }


            if (SceneName == "Keuze4" && index == 2)
            {
                EersteKnopUit();
            }

            //Scene: Keuze5
            if (SceneName == "Keuze4" && index == 11)
            {
                SceneManager.LoadScene("Keuze5");
            }

            //Scene: Keuze6
            if (SceneName == "Keuze5" && index == 8)
            {
                SceneManager.LoadScene("Keuze6");
            }

            if (SceneName == "Keuze6" && index == 7)
            {
                EersteKnop();
            }

            if (SceneName == "Keuze6" && index == 8)
            {
                EersteKnopUit();
            }

            //Scene: Keuze7
            if (SceneName == "Keuze7" && index == 16)
            {
                SceneManager.LoadScene("Keuze8");
            }

            //Scene: Keuze8
            if (SceneName == "Keuze8" && index == 13)
            {
                SceneManager.LoadScene("Keuze9");
            }

            //Scene: Keuze9
            if (SceneName == "Keuze9" && index == 14)
            {
                SceneManager.LoadScene("Keuze10");
            }

            if (SceneName == "Keuze10" && index == 0)
            {
                EersteKnop();
            }

            if (SceneName == "Keuze10" && index == 1)
            {
                EersteKnopUit();
            }

<<<<<<< Updated upstream
=======
            //Scene: Keuze10 -> Keuze11
            if (SceneName == "Keuze10" && index == 26)
            {
                SceneManager.LoadScene("Keuze11");
            }

            if (SceneName == "Keuze11" && index == 0)
            {
                image.sprite = backgrounds[0];
            }

            if (SceneName == "Keuze11" && index == 4)
            {
                image.sprite = backgrounds[4];
            }

            if (SceneName == "Keuze11" && index == 22)
            {
                TweedeKnop();
            }

            if (SceneName == "Keuze11" && index == 23)
            {
                TweedeKnopUit();
            }

            //Scene Keuze11 -> Rebellionstart
            if (SceneName == "Keuze11" && index == 23)
            {
                SceneManager.LoadScene("RebellionStart");
            }









































































>>>>>>> Stashed changes






        //Scene: BadEnding
       

        if (SceneName == "BadEnding" && index == 9) 
        {
         
            TweedeKnopAan();
        }




        //Scene: FollowUpBadEnding


        if (SceneName == "BadEnding2" && index == 16)
        {

            TweedeKnopAan();
        }

    }
}



