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
        currentHp = 3;
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
