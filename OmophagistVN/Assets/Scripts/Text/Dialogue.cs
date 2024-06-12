using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    public string[] Sentences;
    private int Index = 0;
    public float DialogueSpeed;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextSentence(); 
        }
    }


    void NextSentence()
    {
        if (Index <= Sentences.Length - 1)
        {
            textMeshProUGUI.text = "";
            StartCoroutine(WriteSentence());
        }
    }


    IEnumerator WriteSentence()
    {
        foreach(char Character in Sentences[Index].ToCharArray())
        {
            textMeshProUGUI.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);

        }
        Index++;
    }
   

}
