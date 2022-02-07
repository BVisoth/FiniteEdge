using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossHp_Test : MonoBehaviour
{
    public float HitPoints;
    public float MaxHitpoints = 100;
    public HpBar_Test hpBar;
    public Animator animator;

    public void Start()
    {
        HitPoints = MaxHitpoints;
        hpBar.SetHealth(HitPoints, MaxHitpoints);
        Debug.Log("Current Hp: " + HitPoints);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetInteger("Anim", 3);
            HitPoints -= 10;
            hpBar.SetHealth(HitPoints, MaxHitpoints);
            Debug.Log("Current Hp: " + HitPoints);
            animator.SetInteger("Anim", 1);

            if (HitPoints <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
        }
    }
}
