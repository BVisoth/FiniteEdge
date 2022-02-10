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
    public bool dLeft;
    public bool dRight;
    public float lTimer;
    public float rTimer;


    public void Update()
    {
        Skin();
        
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
        else if (phurting == false)
        {
            animator.SetInteger("Anim", 1);
        }
        else
        {
            LDSkin();
            RDSkin();
        }
            
    }

    public void Right()
    {
        dRight = true;
        dLeft = false;
        body.velocity = new Vector2(40, 0);
        AudioSource.PlayClipAtPoint(dashSFX, Camera.main.transform.position);
    }

    private void RDSkin()
    {
        if (dRight == true)
        {
            animator.SetInteger("Anim", 4);
        }
       
    }

    public void Left()
    {
        dLeft = true;
        dRight = false;
        body.velocity = new Vector2(-40, 0);
        AudioSource.PlayClipAtPoint(dashSFX, Camera.main.transform.position);
    }

    private void LDSkin()
    {
        if (dLeft == true)
        {
            animator.SetInteger("Anim", 5);
           
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
