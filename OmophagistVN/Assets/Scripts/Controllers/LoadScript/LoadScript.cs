using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScript : MonoBehaviour
{
    public void LoadSavedScene()
    {
        // Controleer of er een opgeslagen scene is
        if (PlayerPrefs.HasKey("SavedScene"))
        {
            // Haal de naam van de opgeslagen scene op
            string savedSceneName = PlayerPrefs.GetString("SavedScene");

            // Laad de opgeslagen scene
            SceneManager.LoadScene(savedSceneName);

            Debug.Log("Game geladen! Opgeslagen scene: " + savedSceneName);
        }
        else
        {
            Debug.Log("Geen opgeslagen game gevonden. Start standaard scene.");
        }
    }
}