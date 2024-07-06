using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    public string[] Sentences;
    private int Index = 0;
    public float DialogueSpeed;

    public TextMeshProUGUI nameBox;
    public string[] Names;

    public static Action<int>OnSentenceIncrement;
    private bool DialogueActive = true;


    void Start()
    {
        nameBox.text = Names[0];
    }

    public void PauseTheGame()
    {
        DialogueActive = false;
    }

    public void ResumeTheGame()
    {
        DialogueActive = true;
    }

    void Update()
    {
        if (DialogueActive && (Input.GetKeyDown(KeyCode.Space)))
        {
            NextSentence();           
        }
    }


   public void NextSentence()
    {
        //NextSentence();

        if (Index <= Sentences.Length - 1)
        {
            textMeshProUGUI.text = "";
            StartCoroutine(WriteSentence());
            OnSentenceIncrement?.Invoke(Index);
        }
    }


    IEnumerator WriteSentence()
    {
        foreach(char Character in Sentences[Index].ToCharArray())
        {
            textMeshProUGUI.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);

        }

        nameBox.text = Names[Index];

        Index++;
    }


  
}
