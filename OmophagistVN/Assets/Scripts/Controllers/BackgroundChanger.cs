using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;
using UnityEngine.UI;

public class BackgroundChanger : MonoBehaviour
{

    public List<Sprite> backgrounds;
    private Image image;
    // Start is called before the first frame update
    void Start()
    {
        Dialogue.OnSentenceIncrement += ChangeBackground;
        image = GetComponent<Image>();



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeBackground(int index)
    {
      if (index == 2)
      {
            Debug.Log("hoi");
            image.sprite = backgrounds[0];
      }
        if (index == 3) {
            image.sprite = backgrounds[1];
        }
    }
}
