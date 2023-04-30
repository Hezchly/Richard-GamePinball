using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button creditsButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
        creditsButton.onClick.AddListener(credits);
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("Main_Game");
    }

    private void ExitGame()
    {
        Application.Quit();
    }

    private void credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
