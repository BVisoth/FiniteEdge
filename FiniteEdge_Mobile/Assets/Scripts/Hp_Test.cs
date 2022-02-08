using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Hp_Test : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI hpText;
    [SerializeField] public AudioClip hitSFX;
    public static int currentHp = 5;

    private void Start()
    {
       
            currentHp = 5;
        
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
            AudioSource.PlayClipAtPoint(hitSFX, Camera.main.transform.position);
            Debug.Log("Current Hp: " + currentHp);
            hpText.text = "Current Hp: " + currentHp;
            Movement.phurting = true;
        }

        if(currentHp <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
