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
    public static bool pattack;
    public float ptimer;
    public float minX = -7;
    public float maxX = 7;



    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Left();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Right();
        }
        Skin();
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y, transform.position.z);
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
       else if (pattack == true)
        {
            animator.SetInteger("Anim", 2);
            ptimer += Time.deltaTime;
            if (ptimer > 1)
            {
                htimer = 0;
                pattack = false;
            }
        }
        else 
        {
         Vector2 apple =  new Vector2  (0, 0);
            if (body.velocity == apple)
            {
                dRight = false;
                dLeft = false;
            }

            if (dLeft == true || dRight == true)
            {
                LDSkin();
                RDSkin();
            }
             else

            {
                animator.SetInteger("Anim", 1);

            }


        }
       
            
    }

    public void Right()
    {
        dRight = true;
        dLeft = false;
        body.velocity = new Vector2(20, 0);
        AudioSource.PlayClipAtPoint(dashSFX, Camera.main.transform.position);
    }
    public void Left()
    {
        dLeft = true;
        dRight = false;
        body.velocity = new Vector2(-20, 0);
        AudioSource.PlayClipAtPoint(dashSFX, Camera.main.transform.position);
    }
    private void RDSkin()
    {
        if (dRight == true)
        {
            animator.SetInteger("Anim", 4);
        }
       
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
            dRight = false;
            dLeft = false;
        }

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Stopper")
        {
            
            dRight = false;
            dLeft = false;
        }
    }
}
