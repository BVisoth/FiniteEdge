using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPreset : MonoBehaviour
{
    public float counter;
   static public int ran1;
    public int apple;
    public Transform[] positions;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    
    {
        counter += Time.deltaTime;
        if (counter >= 1)
        {
            counter = 0;
            apple = Random.Range(0, positions.Length);
            ran1 = apple;
            Vector3 position = positions[apple].position;
            Instantiate(ball, position, Quaternion.identity);
        }

    }
}

