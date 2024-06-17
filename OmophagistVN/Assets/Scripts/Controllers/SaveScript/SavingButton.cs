using UnityEngine;
using UnityEngine.SceneManagement;

public class SavingButton : MonoBehaviour
{
    public NameChangeSave NameChangeSaveScript; // Referentie naar het NameChangeSave script

    public void SaveGame()
    {
        // Krijg de huidige scene naam
        string sceneName = SceneManager.GetActiveScene().name;

        // Sla de huidige scene op en overschrijf de oude naam
        PlayerPrefs.SetString("SavedScene", sceneName);
        PlayerPrefs.Save();

        Debug.Log("Game opgeslagen! Huidige scene: " + sceneName);

        // Update de tekst
        NameChangeSaveScript.UpdateText();
    }
}