using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHp_Test : MonoBehaviour
{
    public float HitPoints;
    public float MaxHitpoints = 5;
    public HpBar_Test hpBar;

    public void Start()
    {
        HitPoints = MaxHitpoints;
        hpBar.SetHealth(HitPoints, MaxHitpoints);
        Debug.Log("Current Hp: " + HitPoints);
    }

    public void Update()
    {
        hpBar.SetHealth(HitPoints, MaxHitpoints);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            HitPoints -= 10;
            Debug.Log("Current Hp: " + HitPoints);
        }
    }
}
