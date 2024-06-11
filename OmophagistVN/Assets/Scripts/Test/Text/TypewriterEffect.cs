using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TypewriterEffect : MonoBehaviour, IPointerClickHandler
{
    public Text uiText;
    public string fullText;
    public float initialDelay = 0.1f; // Begin delay
    private float delay;
    private Coroutine typingCoroutine;

    private void OnEnable()
    {
        delay = initialDelay; // Reset delay bij het activeren van het object
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
        }
        typingCoroutine = StartCoroutine(ShowText());
    }

    private IEnumerator ShowText()
    {
        uiText.text = "";
        foreach (char letter in fullText.ToCharArray())
        {
            uiText.text += letter;
            yield return new WaitForSeconds(delay);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
       
        delay *= 0.5f; 
    }
}