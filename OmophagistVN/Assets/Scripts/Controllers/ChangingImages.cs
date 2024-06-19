using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingImages : MonoBehaviour
{
    public Image image;
    public List<Sprite> spriteChoices;

    private int counter;
    private int currentSprite = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextImage()
    {
        counter++;
        print(counter);
        if (counter == 5) //na een bepaald hoeveelheid klikjes veranderd 
        {
            currentSprite++;
            counter = 0; //klikjes reset opnieuw klikken voor andere image
            if (currentSprite >= spriteChoices.Count)
            {
                currentSprite = 0;
            }
            image.sprite = spriteChoices[currentSprite];
        }

    }
}

