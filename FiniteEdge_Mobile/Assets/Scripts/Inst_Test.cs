using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inst_Test : MonoBehaviour
{

    [SerializeField] GameObject ball;
    public Transform Location;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ball, Location.position, Location.rotation);
        }
    }
}
