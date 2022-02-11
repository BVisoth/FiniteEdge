using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dif_Test : MonoBehaviour
{
    public static bool easy;
    public static bool hard;
    public static bool normal;

    void Start()
    {
        easy = false;
        hard = false;
        normal = false;
    }

    public void EasyModeOn()
    {
        easy = true;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void HardModeOn()
    {
        hard = true;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void NormalModeOn()
    {
        normal = true;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
