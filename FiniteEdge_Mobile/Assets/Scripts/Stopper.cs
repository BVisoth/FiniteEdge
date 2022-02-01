using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stopper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This script is useless lol dont use it abcdefghijklmnopqurtuvwxyz....haha hope no one reads this lol that'd be weird... Hello if anyone is there...
        //     :)      <3       ;)        XD           <3         lolz        :3        >:)        :p     :0
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
