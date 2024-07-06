using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class SpriteChanger : MonoBehaviour
{

    public List<Sprite> sprites;
    private Image image;

    public string SceneName { get; private set; }

    // Start is called before the first frame update
    void Start()
    {

        Dialogue.OnSentenceIncrement += ChangeSprites;
        image = GetComponent<Image>();
        image.sprite = sprites[0];
        SceneName = SceneManager.GetActiveScene().name;



        //Scene: BadEnding
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeSprites(int index)
    {
        if (SceneName == "Dialogue" && index == 0)
        {
            //Debug.Log("hoi");
            image.sprite = sprites[0];
        }

        if (SceneName == "Dialogue" && index == 2)
        {
            image.sprite = sprites[2];
        }

        if (SceneName == "Dialogue" && index == 6)
        {
            image.sprite = sprites[6];
        }

        //Scene: Keuze1
        //Servant
        if (SceneName == "Keuze1" && index == 0)
        {
            image.sprite = sprites[0];
        }

        if (SceneName == "Keuze1" && index == 2 )
        {
            image.sprite = sprites[2];
        }

        if (SceneName == "Keuze1" && index == 4)
        {
            image.sprite = sprites[4];
        }

        //Heraeus
        if (SceneName == "Keuze1" && index == 1)
        {
            image.sprite = sprites[1];
        }

        //Heraues -> Shadow
        if (SceneName == "Keuze1" && index == 4)
        {
            image.sprite = sprites[4];
        }

        //Scene: Keuze2
        //Servant
        if (SceneName == "Keuze2" && index == 1)
        {
            image.sprite = sprites[0];
        }


        //Lycaon
        if (SceneName == "Keuze2" && index == 2)
        {
            image.sprite = sprites[2];
        }
        //Lycaon -> Shadow
        if (SceneName == "Keuze2" && index == 11)
        {
            image.sprite = sprites[11];
        }

        //Heraeus
        if (SceneName == "Keuze2" && index == 1)
        {
            image.sprite = sprites[1];
        }

        //Nyctimus
        if (SceneName == "Keuze2" && index == 5)
        {
            image.sprite = sprites[5];
        }


        //Scene: Keuze3
        //Servant sprites
        if (SceneName == "Keuze3" && index == 0)
        {
            image.sprite = sprites[0];
        }

        if (SceneName == "Keuze3" && index == 1)
        {
            image.sprite = sprites[1];
        }

        if (SceneName == "Keuze3" && index == 2)
        {
            image.sprite = sprites[2];
        }

        if (SceneName == "Keuze3" && index == 21)
        {
            image.sprite = sprites[21];
        }

        if (SceneName == "Keuze3" && index == 22)
        {
            image.sprite = sprites[22];
        }

        //Lycaon sprites
        if (SceneName == "Keuze3" && index == 0)
        {
            image.sprite = sprites[0];
        }

        if (SceneName == "Keuze3" && index == 3)
        {
            image.sprite = sprites[3];
        }
        //Lycaon -> Shadow
        if (SceneName == "Keuze3" && index == 20)
        {
            image.sprite = sprites[20];
        }

        //Nyctimus
        if (SceneName == "Keuze3" && index == 3)
        {
            image.sprite = sprites[3];
        }

        if (SceneName == "Keuze3" && index == 17)
        {
            image.sprite = sprites[17];
        }


        //Scene: Keuze4
        //Servant
        if (SceneName == "Keuze4" && index == 0)
        {
            image.sprite = sprites[0];
        }

        if (SceneName == "Keuze4" && index == 2)
        {
            image.sprite = sprites[2];
        }

        if (SceneName == "Keuze4" && index == 3)
        {
            image.sprite = sprites[3];
        }

        //Lycaon
        if (SceneName == "Keuze4" && index == 5)
        {
            image.sprite = sprites[5];
        }

        if (SceneName == "Keuze4" && index == 6)
        {
            image.sprite = sprites[4];
        }


        //Scene: Keuze5
        //Apollon
        if (SceneName == "Keuze5" && index == 0)
        {
            image.sprite = sprites[0];
        }

        if (SceneName == "Keuze5" && index == 1)
        {
            image.sprite = sprites[1];
        }

        //Artemis
        if (SceneName == "Keuze5" && index == 5)
        {
            image.sprite = sprites[5];
        }


        //Scene: Keuze6
        //Aphrodite
        if (SceneName == "Keuze6" && index == 1)
        {
            image.sprite = sprites[2];
        }

        //Ares
        if (SceneName == "Keuze6" && index == 3)
        {
            image.sprite = sprites[4];
        }

        //Scene: Keuze7
        //Lycaon
        if (SceneName == "Keuze7" && index == 4)
        {
            image.sprite = sprites[4];
        }

        //Scene: Keuze8
        //Aphrodite
        if (SceneName == "Keuze8" && index == 0)
        {
            image.sprite = sprites[0];
        }

        //HeraZeus
        if (SceneName == "Keuze8" && index == 1)
        {
            image.sprite = sprites[1];
        }

        //Hestia
        if(SceneName == "Keuze8" && index == 3)
        {
            image.sprite = sprites[3];
        }

        if (SceneName == "Keuze8" && index == 6)
        {
            image.sprite = sprites[6];
        }

        //Servant
        if (SceneName == "Keuze8" && index == 4)
        {
           image.sprite = sprites[4];
        }


        //Scene: Keuze9
        //Nyctimus -> Servant 
        if (SceneName == "Keuze9" && index == 3)
        {
            image.sprite = sprites[3];
        }


        //Scene: Keuze10
        if (SceneName == "Keuze10" && index == 5)
        {
            image.sprite = sprites[5];
        }


        //Scene: Keuze11
        //Servant
        if (SceneName == "Keuze11" && index == 11)
        {
            image.sprite = sprites[11];
        }


        //Lycaon
        if (SceneName == "Keuze11" && index == 0)
        {
            image.sprite = sprites[0];
        }

        if (SceneName == "Keuze11" && index == 1)
        {
            image.sprite = sprites[1];
        }

        if (SceneName == "Keuze11" && index == 2)
        {
            image.sprite = sprites[2];
        }

        //Apollon
        if (SceneName == "Keuze11" && index == 7)
        {
            image.sprite = sprites[7];
        }

        if (SceneName == "Keuze11" && index == 10)
        {
            image.sprite = sprites[10];
        }

        if (SceneName == "Keuze11" && index == 20)
        {
            image.sprite = sprites[20];
        }

        //Apollon -> Shadow
        if (SceneName == "Keuze11" && index == 21)
        {
            image.sprite = sprites[21];
        }






























































        // Scene : BadEnding
        if (SceneName == "BadEnding" && index ==1 )
        {
            image.sprite = sprites[1];
        }
        
        if (SceneName == "BadEnding" && index == 8)
        {
            image.sprite = sprites[2];
        }

    }
}
