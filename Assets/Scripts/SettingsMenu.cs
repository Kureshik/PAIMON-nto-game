using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    //public Dropdown graphicsDropdown;
    public AudioMixer mixer;

    public Slider musicSlider;
    public Slider sfxSlider;
    public Button applyButton;

    private void Start()
    {
        LoadSettings();

        //graphicsDropdown.onValueChanged.AddListener(delegate { OnGraphicsQualityChanged(); });
        musicSlider.onValueChanged.AddListener(delegate { OnMusicVolumeChanged(); });
        sfxSlider.onValueChanged.AddListener(delegate { OnSFXVolumeChanged(); });
        applyButton.onClick.AddListener(delegate { OnApplyButtonClicked(); });
    }

    private void LoadSettings()
    {
        //int graphicsQuality = PlayerPrefs.GetInt("GraphicsQuality", 2);
        //graphicsDropdown.value = graphicsQuality;

        float musicVolume = PlayerPrefs.GetFloat("MusicVolume", 0);
        musicSlider.value = musicVolume;
        mixer.SetFloat("MusicVolume", Mathf.Log10(musicVolume)*20);

        float sfxVolume = PlayerPrefs.GetFloat("SFXVolume", 0);
        sfxSlider.value = sfxVolume;
        mixer.SetFloat("SFXVolume", Mathf.Log10(sfxVolume) * 20);
    }

    private void OnGraphicsQualityChanged()
    {
        //int graphicsQuality = graphicsDropdown.value;
        //QualitySettings.SetQualityLevel(graphicsQuality);

        //PlayerPrefs.SetInt("GraphicsQuality", graphicsQuality);
    }

    private void OnMusicVolumeChanged()
    {
        float musicVolume = musicSlider.value;
        mixer.SetFloat("MusicVolume", Mathf.Log10(musicVolume) * 20);
        
        PlayerPrefs.SetFloat("MusicVolume", musicVolume);
    }

    private void OnSFXVolumeChanged()
    {
        float sfxVolume = sfxSlider.value;
        mixer.SetFloat("SFXVolume", Mathf.Log10(sfxVolume) * 20);

        PlayerPrefs.SetFloat("SFXVolume", sfxVolume);
    }

    private void OnApplyButtonClicked()
    {
        PlayerPrefs.Save();
    }
}