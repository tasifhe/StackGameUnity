using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text scoreText;
    public GameObject UI_MainMenu;

    public GameObject UI_Setting;
    public GameObject UI_HighScore;
    public Slider slider;

    public void ToGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Back()
    {
        UI_HighScore.SetActive(false);
        UI_Setting.SetActive(false);

        UI_MainMenu.SetActive(true);
    }

    public void HighScore()
    {
        scoreText.text = PlayerPrefs.GetInt("score").ToString();
        UI_MainMenu.SetActive(false);

        UI_HighScore.SetActive(true);
    }

    public void Setting()
    {
        UI_MainMenu.SetActive(false);
        UI_Setting.SetActive(true);
    }

    public void SettingAudio()
    {
        AudioListener.volume = slider.value;
    }

    public void Reset()
    {
        PlayerPrefs.SetInt("score", 0);
    }
}