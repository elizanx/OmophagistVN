using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour
{

    public List<Sprite> sprites;
    private Image image;
    
    // Start is called before the first frame update
    void Start()
    {
        Dialogue.OnSentenceIncrement += ChangeSprites;
        image = GetComponent<Image>();
        image.sprite = sprites[0];
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeSprites(int index)
    {
        if (index == 1)
        {
            //Debug.Log("hoi");
            image.sprite = sprites[1];

        }
        if (index == 2)
        {
            image.sprite = sprites[2];
        }
    }
}
