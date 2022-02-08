using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadLastScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex - 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
        FindObjectOfType<Level>();
    }

    public void One()
    {
        SceneManager.LoadScene(1);
        FindObjectOfType<Level>();
    }

    public void Two()
    {
        SceneManager.LoadScene(2);
        FindObjectOfType<Level>();
    }

    public void Three()
    {
        SceneManager.LoadScene(3);
        FindObjectOfType<Level>();
    }

    public void Four()
    {
        SceneManager.LoadScene(4);
        FindObjectOfType<Level>();
    }

    public void Five()
    {
        SceneManager.LoadScene(5);
        FindObjectOfType<Level>();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
}
