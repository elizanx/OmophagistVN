using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayText : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    public Text obj_text;
    public InputField Display;

    // Start is called before the first frame update
    void Start()
    {
        obj_text.text = PlayerPrefs.GetString("user_name");
    }

    public void Create()
    {
        obj_text.text = Display.text;
        PlayerPrefs.SetString("user_name", obj_text.text);
        PlayerPrefs.Save();
    }
    void Update()
    {

    }
}