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

    public AudioSource heartbeatAudio;
    public AudioSource WhispersAudio;
    public AudioSource BattleGroundMusic;
    public AudioSource SwordsSound;
    public AudioSource AmbientAudio;
    public AudioSource ManScream;
    public AudioSource HeavyBreathing;

    // Start is called before the first frame update
    void Start()
    {
        Dialogue.OnSentenceIncrement += ChangeBackground;
        image = GetComponent<Image>();
        SceneName = SceneManager.GetActiveScene().name;

        KnoppenUit();



        if (heartbeatAudio.isPlaying)
        {
            heartbeatAudio.Stop();
        }

        if (WhispersAudio.isPlaying)
        {
            WhispersAudio.Stop();
        }

        if (BattleGroundMusic.isPlaying)
        {
            BattleGroundMusic.Stop();
        }

        if (SwordsSound.isPlaying)
        {
            SwordsSound.Stop();
        }

        if (!AmbientAudio.isPlaying)
        {
            AmbientAudio.Play();
        }

        if (ManScream.isPlaying)
        {
            ManScream.Stop();
        }
        if (HeavyBreathing.isPlaying)
        {
            HeavyBreathing.Stop();
        }









        //Scene: RebellionStart
        if (SceneName == "RebellionStart")
        {
            image.sprite = backgrounds[0];
        }



        //Scene: RebellionNight
        if (SceneName == "RebellionNight")
        {
            image.sprite = backgrounds[0];
        }


        //Scene: RebellionPrepare
        if (SceneName == "RebellionPrepare")
        {
            image.sprite = backgrounds[0];
        }

        //Scene: TheWayToLycaon
        if (SceneName == "TheWayToLycaon")
        {
            image.sprite = backgrounds[0];
        }


        //Scene: Victory...OrNot
        if (SceneName == "Victory...OrNot")
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
        
        
        void TweedeKnop()
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
                image.sprite = backgrounds[0];
            }


            if (SceneName == "Dialogue" && index == 3)
            {
                //Debug.Log("Dit is de 3e zin");
                EersteKnop();
            }


            if (SceneName == "Dialogue" && index == 4)
            {
                Debug.Log("Zin 4/ Interactief button");
                EersteKnopUit();
            }

            //Scene: Dialogue -> Keuze1
            if (SceneName == "Dialogue" && index == 8)
            {
                SceneManager.LoadScene("Keuze1");
            }

            if (SceneName == "Keuze1" && index == 5)
            {
                Debug.Log("Werkt dit?");
                EersteKnop();
            }

            if (SceneName == "Keuze1" && index == 6)
            {
                Debug.Log("Werkt dit?");
                EersteKnopUit();
            }

       
             //Scene: Keuze1 -> Keuze2
            if (SceneName == "Keuze1" && index == 6)
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


            //Scene: Keuze2 -> Keuze3
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

            //Scene: Keuze3 -> Keuze4
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

            if (SceneName == "Keuze4" && index == 3)
            {
                image.sprite = backgrounds[3];
            }

            //Scene: Keuze4 -> Keuze5
            if (SceneName == "Keuze4" && index == 11)
            {
                SceneManager.LoadScene("Keuze5");
            }

            //Scene: Keuze5 -> Keuze6
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

            //Scene Keuze6 -> Keuze7
            if (SceneName == "Keuze6" && index == 8)
            {
                SceneManager.LoadScene("Keuze7");
            }

            //Scene: Keuze7 -> Keuze8
            if (SceneName == "Keuze7" && index == 16)
            {
                SceneManager.LoadScene("Keuze8");
            }

            //Scene: Keuze8 -> Keuze9
            if (SceneName == "Keuze8" && index == 13)
            {
                SceneManager.LoadScene("Keuze9");
            }

            //Scene: Keuze9 -> Keuze10
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


















































































        //Scene: BadEnding
        if (SceneName == "RebellionStart" && index == 10) 
            {
                TweedeKnop();
            }


        //Scene: RebellionNight
        if (SceneName == "RebellionNight" && index == 7)
        {
            TweedeKnop();
        }


        //Scene: RebellionPrepare

        if (SceneName == "RebellionPrepare" && index == 2)
        {
            if (!WhispersAudio.isPlaying)
            {
                WhispersAudio.Play();
            }
        }

        if (SceneName == "RebellionPrepare" && index == 3)
        {
            if (!heartbeatAudio.isPlaying)
            {
                heartbeatAudio.Play();
            }
        }

       


        if (SceneName == "RebellionPrepare" && index == 17)
        {
            TweedeKnop();
        }



        //Scene: TheWayToLycaon
        if (SceneName == "TheWayToLycaon" && index == 2)
        {
            image.sprite = backgrounds[1];
        }

        if (SceneName == "TheWayToLycaon" && index == 2)
        {
            if (AmbientAudio.isPlaying)
            {
                AmbientAudio.Stop();
            }

            if (!BattleGroundMusic.isPlaying)
            {
                BattleGroundMusic.Play();
            }
        }
        if (SceneName == "TheWayToLycaon" && index == 9)
        {
            if (!SwordsSound.isPlaying)
            {
                SwordsSound.Play();
            }
        }

        if (SceneName == "TheWayToLycaon" && index == 19)
        {
            TweedeKnop();
        }


        //Scene: Victory...OrNot

        if (SceneName == "Victory...OrNot" && index == 0)
        {
            ManScream.Play();
        }

        if (SceneName == "Victory...OrNot" && index == 1)
        {
            HeavyBreathing.Play();
        }

        if (SceneName == "Victory...OrNot" && index == 5)
        {
            image.sprite = backgrounds[1];
        }

        if (SceneName == "Victory...OrNot" && index == 12)
        {
            SceneManager.LoadScene("BadEnding");
        }
    }
}



