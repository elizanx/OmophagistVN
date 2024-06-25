using UnityEngine;
using UnityEngine.SceneManagement;

public class SavingButton : MonoBehaviour
{
    public NameChangeSave NameChangeSaveScript;

    public void SaveGame()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("SavedScene", sceneName);
        PlayerPrefs.Save();


        NameChangeSaveScript.UpdateText();
        Debug.Log("Game opgeslagen! Huidige scene: " + sceneName);
        
    }
}