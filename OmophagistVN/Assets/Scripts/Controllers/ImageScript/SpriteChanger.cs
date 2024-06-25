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



    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeSprites(int index)
    {
        if (index == 2)
        {
            //Debug.Log("hoi");
            image.sprite = sprites[0];
        }
        if (index == 3)
        {
            image.sprite = sprites[1];
        }
    }
}
