using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D body;
   [SerializeField] public AudioClip dashSFX;
    public static bool phurting;
    public float htimer;


    public void Update()
    {
        Skin();
        new Vector2 = 
    }

    private void Skin()
    {
        if (phurting == true)
        {
            animator.SetInteger("Anim", 3);
            htimer += Time.deltaTime;
            if (htimer > 1)
            {
                htimer = 0;
                phurting = false;
            }
        }
        else if ()
        {

        }
    }
    public void Right()
    {

        body.velocity = new Vector2(40, 0);
        AudioSource.PlayClipAtPoint(dashSFX, Camera.main.transform.position);
        animator.SetInteger("Anim", 4);
    }

    public void Left()
    {

        body.velocity = new Vector2(-40, 0);
        AudioSource.PlayClipAtPoint(dashSFX, Camera.main.transform.position);
        animator.SetInteger("Anim", 4);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Stopper")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
