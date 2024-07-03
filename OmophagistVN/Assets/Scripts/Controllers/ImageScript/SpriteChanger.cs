using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeSprites(int index)
    {
        if (SceneName == "Dialogue" && index == 1)
        {
            //Debug.Log("hoi");
            image.sprite = sprites[1];

        }
        if (SceneName == "Dialogue" && index == 2)
        {
            image.sprite = sprites[2];
        }

        if (SceneName == "Dialogue" && index == 6)
        {
            image.sprite = sprites[6];
        }

        


        if (SceneName == "Dialogue" && index == 11)
        {
            SceneManager.LoadScene("Keuze1");
        }
        //Scene: Keuze1

        if (SceneName == "Keuze1" && index == 0)
        {
            Debug.Log("Hallo");
            image.sprite = sprites[0];
            
        }

        if (SceneName == "Keuze1" && index == 2 )
        {
            Debug.Log("Hoi");
            image.sprite = sprites[2];

        }

        //Scene: Keuze2
        if (SceneName == "Keuze2" && index == 1)
        {
            image.sprite = sprites[0];
        }

        if (SceneName == "Keuze2" && index == 1)
        {
            image.sprite = sprites[1];
        }

        if (SceneName == "Keuze2" && index == 2)
        {
            image.sprite = sprites[2];
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

        if (SceneName == "Keuze3" && index == 3)
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








        // Scene : BadEnding

        if (SceneName == "BadEnding" && index == 1) 
        {
            image.sprite = sprites[0];
        }


        // Scene : FollowUpBadEnding

        if (SceneName == "BadEnding2" && index == 1)
        {
            image.sprite = sprites[0];
        }
    }
}
