using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp_Test : MonoBehaviour
{
    public static int currentHp = 3;
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        currentHp -= 1;
        Debug.Log("Current Hp:" + currentHp);
    }
}
