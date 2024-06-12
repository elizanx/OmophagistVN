using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class SceneSaver : MonoBehaviour
{
    public Button saveButton;

    private void Start()
    {
        // Zorg ervoor dat de knop gekoppeld is aan de methode die de scene opslaat
        saveButton.onClick.AddListener(SaveActiveScene);
    }

    void SaveActiveScene()
    {
        // De huidige actieve scene opslaan
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        

        // Wachten tot het einde van het frame om ervoor te zorgen dat de scene volledig geladen is
        StartCoroutine(SaveSceneCoroutine(filePath, currentScene));

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
