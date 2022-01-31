using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Hp_Test : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI hpText;

    public static int currentHp = 3;

    private void Start()
    {
        hpText.text = "Current Hp: " + currentHp;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        currentHp -= 1;
        Debug.Log("Current Hp: " + currentHp);
        hpText.text = "Current Hp: " + currentHp;

        if(currentHp <= 0)
        {
            SceneManager.LoadScene("GameOver2");
        }
    }
}
