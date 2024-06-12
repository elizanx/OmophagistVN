using UnityEngine;
using UnityEngine.SceneManagement;

public class SavingButton : MonoBehaviour
{
    public void SaveGame()
    {
        // Krijg de huidige scene naam
        string sceneName = SceneManager.GetActiveScene().name;

        // Sla de huidige scene op
        PlayerPrefs.SetString("SavedScene", sceneName);
        PlayerPrefs.Save();

        Debug.Log("Game opgeslagen! Huidige scene: " + sceneName);
    }
}