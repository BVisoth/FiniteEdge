using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Hp_Test : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI hpText;

    public static int currentHp = 5;

    private void Start()
    {
        if (Dif_Test.easy == true)
        {
            currentHp = 7;
        }
        else if (Dif_Test.hard == true)
        {
            currentHp = 3;
        }
        else
        {
            currentHp = 5;
        }
    }

    private void Update()
    {
        hpText.text = "Current Hp: " + currentHp;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            currentHp -= 1;
            Debug.Log("Current Hp: " + currentHp);
            hpText.text = "Current Hp: " + currentHp;
        }

        if(currentHp <= 0)
        {
            SceneManager.LoadScene("GameOver2");
        }
    }
}
