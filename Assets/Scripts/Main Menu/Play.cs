using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class Play : MonoBehaviour
{
    public TextMeshProUGUI buttonText;

    void Start()
    {
        if (PlayerPrefs.GetInt("visited", 0) == 1) buttonText.text = "опнднкфхрэ";
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("visited", 1);
        SceneManager.LoadScene("Lobby");
    }

    public void ClearPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
