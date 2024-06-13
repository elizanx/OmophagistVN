using UnityEngine;
using UnityEngine.UI;

public class NameChangeSave : MonoBehaviour
{
    public Text displayText; // Referentie naar de Text-component

    void Start()
    {
       
        if (PlayerPrefs.HasKey("SavedScene"))
        {
            string savedSceneName = PlayerPrefs.GetString("SavedScene");
            displayText.text = "Load " + savedSceneName;
        }
        else
        {
            displayText.text = "No saved game found";
        }
    }
}