using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private Slider VolumeSlider;

    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1f);
        }
        Load();
    }

    public void ChangeVolume()
    {
        AudioListener.volume = VolumeSlider.value;
        Save();
    }
    
    private void Load()
    {
        VolumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
        AudioListener.volume = VolumeSlider.value; // Zorg ervoor dat het volume correct wordt ingesteld
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", VolumeSlider.value);
        PlayerPrefs.Save(); // Zorg ervoor dat de wijzigingen worden opgeslagen
    }
}