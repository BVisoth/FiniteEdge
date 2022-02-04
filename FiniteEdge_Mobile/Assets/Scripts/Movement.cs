using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetInteger("Anim", 2);
            GetComponent<Rigidbody2D>().velocity = new Vector2(40, 0);
            
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.SetInteger("Anim", 3);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-40, 0);
            
        }

    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Stopper")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
