using UnityEngine;
using UnityEngine.UI;

public class NameChangeSave : MonoBehaviour
{
    public Text displayText; 

    void Start()
    {
        UpdateText();
    }

    public void UpdateText()
    {
        
        if (PlayerPrefs.HasKey("SavedScene"))
        {
            
            string savedSceneName = PlayerPrefs.GetString("SavedScene");
            displayText.text = savedSceneName;
        }
        else
        {
            displayText.text = "No saved game found";
        }
    }
}