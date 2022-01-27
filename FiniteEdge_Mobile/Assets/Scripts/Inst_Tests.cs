using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inst_Tests : MonoBehaviour
{
    public Transform[] pos;

    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        int n = Random.Range(0, pos.Length);

        Instantiate(ball, pos[n]);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
