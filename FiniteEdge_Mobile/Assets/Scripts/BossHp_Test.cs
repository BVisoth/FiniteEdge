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
            HitPoints -= 10;
            hpBar.SetHealth(HitPoints, MaxHitpoints);
            Debug.Log("Current Hp: " + HitPoints);

            if(HitPoints <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(5);
            }
        }
    }
}
