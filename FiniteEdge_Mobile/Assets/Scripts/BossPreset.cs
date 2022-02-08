using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossPreset : MonoBehaviour
{
    public float counter;
    public float acounter;
    static public int ran1;
    public int apple;
    public Transform[] positions;
    public GameObject ball;
    public float atime;
    [SerializeField] public int atimeset;
    [SerializeField] public int sscount;
    public int scount;
    public bool atimecheck;
    public bool scountcheck;
    [SerializeField] static public int bigmanhealth;
    public Animator animator;
    public float HitPoints;
    public float MaxHitpoints = 100;
    public HpBar_Test hpBar;

    // Start is called before the first frame update
    void Start()
    {
        atime = atimeset / singleton.diA;
        HitPoints = MaxHitpoints;
        hpBar.SetHealth(HitPoints, MaxHitpoints);
        Debug.Log("Current Hp: " + HitPoints);
    }

    // Update is called once per frame
    void Update()

    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            HitPoints -= 10;
            hpBar.SetHealth(HitPoints, MaxHitpoints);
            Debug.Log("Current Hp: " + HitPoints);

            if (HitPoints <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            }
        }

        if (scount > 0)
        {
            Shoot();
            animator.SetInteger("Anim", 2);
        }
        else
        {
            if (atimecheck == false)
            {
                atime = atimeset / singleton.diA;
                atimecheck = true;
                scountcheck = false;
              
            }
               

           
        }
        if (atime > 0)
        {
            animator.SetInteger("Anim", 1);
            acounter += Time.deltaTime;
            if (acounter >= 1)
            {
                acounter = 0;
                atime = atime - 1;
            }
        }
        else if (atime <= 0)
        {
            if (scountcheck == false)
            {
                scount = sscount * singleton.diA;
                scountcheck = true;
                atimecheck = false;
                
            }


        }
    }

    private void Shoot()
    {
        counter += Time.deltaTime;
        if (counter >= 1)
        {
            counter = 0;
            apple = Random.Range(0, positions.Length);
            ran1 = apple;
            Vector3 position = positions[apple].position;
            Instantiate(ball, position, Quaternion.identity);
            scount = scount - 1;
        }
    }
}

