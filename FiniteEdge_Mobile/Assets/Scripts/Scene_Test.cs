using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Test : MonoBehaviour
{
    public Level lvFinder;

    public void LoadNextScene()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void LoadTest()
    {
        lvFinder = FindObjectOfType<Level>();
    }
}
