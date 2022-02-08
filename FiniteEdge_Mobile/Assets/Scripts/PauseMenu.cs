using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public void Pause()
    {
    Time.timeScale = 0;
    GetComponent<Canvas>().enabled = true;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        GetComponent<Canvas>().enabled = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
