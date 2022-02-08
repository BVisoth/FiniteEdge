using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D body;
   [SerializeField] public AudioClip dashSFX; 

        public void Right()
        {
            
            body.velocity = new Vector2(40, 0);
            AudioSource.PlayClipAtPoint(dashSFX, Camera.main.transform.position);
        }

        public void Left()
        {
            
            body.velocity = new Vector2(-40, 0);
            AudioSource.PlayClipAtPoint(dashSFX, Camera.main.transform.position);
        }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Stopper")
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
