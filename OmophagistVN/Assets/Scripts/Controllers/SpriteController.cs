using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteController : MonoBehaviour
{

    public bool isSwitched = false;
    public Image servantnormal;
    public Image servantsmile;
    public Image aresnormal;
    public Image hermesnormal;
    public Image athenanormal;
    public Image artemisnormal;
    public Image domosandpheibosnormal;
    public Animator animator;

    public void SwitchImage(Sprite sprite)
    {
        if (!isSwitched)
        {
            servantnormal.sprite = sprite;
            animator.SetTrigger("SwitchFirst");
        }
        else
        {
            servantsmile.sprite = sprite;
            animator.SetTrigger("SwitchSecond");
        }
        isSwitched = !isSwitched;
    }

    public void SetImage(Sprite sprite)
    {
        if (!isSwitched)
        {
            servantnormal.sprite = sprite;
        }
        else
        {
            servantsmile.sprite = sprite;
        }
    }
}
