using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHp_Test : MonoBehaviour
{
    public static int Hp = 100;
    public float HitPoints;
    public float MaxHitpoints = 5;
    public HpBar_Test hpBar;

    private void Start()
    {
        Debug.Log("Current Hp: " + Hp);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Hp -= 10;
            Debug.Log("Current Hp: " + Hp);
        }
    }
}
