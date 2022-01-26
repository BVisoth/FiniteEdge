using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPreset : MonoBehaviour
{
    public float counter;
   static public int ran1;
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
            ran1 = Random.Range(1, 5);

          
        }

    }
}

