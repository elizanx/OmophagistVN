using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScript : MonoBehaviour
{
    public void LoadSavedScene()
    {
        
        if (PlayerPrefs.HasKey("SavedScene"))
        {
            
            string savedSceneName = PlayerPrefs.GetString("SavedScene");
            SceneManager.LoadScene(savedSceneName);3
            Debug.Log("Game geladen! Opgeslagen scene: " + savedSceneName);
        }
        else
        {
            Debug.Log("Geen opgeslagen game gevonden. Start standaard scene.");
        }
    }
}