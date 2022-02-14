using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossPreset : MonoBehaviour
{
    [SerializeField] public AudioClip damageSFX;
    public float counter;
    public float acounter;
    static public int ran1;
    public int randomnumberchosen = -1;
    public int lastShot;
    public Transform[] positions;
    public GameObject ball;
    public static float atime;
    [SerializeField] public int atimeset;
    [SerializeField] public int sscount;
    public float scount;
    public bool atimecheck;
    public bool scountcheck;
    [SerializeField] static public int bigmanhealth;
    public Animator animator;
   static public float HitPoints;
    public float MaxHitpoints = 100;
    public HpBar_Test hpBar;
    public bool hurting;
    public float htimer;
    public static bool attk;

    public float factor;

    // Start is called before the first frame update
    void Start()
    {
        atime = (atimeset / singleton.diA ) + 5;
        HitPoints = MaxHitpoints + (40 * singleton.diA);
        hpBar.SetHealth(HitPoints, MaxHitpoints);
        Debug.Log("Current Hp: " + HitPoints);
        MaxHitpoints = HitPoints;
    }

    // Update is called once per frame
    void Update()

    {
        if (attk == true)
        {
            att();
        }
        Skin();

        if (scount > 0)
        {
            Shoot();

        }
        else
        {
            if (atimecheck == false)
            {
                atime = (atimeset * 1.2f) - ((atimeset * 0.8f) / singleton.diA);
                atimecheck = true;
                scountcheck = false;

            }



        }
        if (atime > 0)
        {

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
                scount = (sscount * 0.6f) + ((sscount * 0.4f) * singleton.diA);
                scountcheck = true;
                atimecheck = false;

            }


        }
    }

    private void Skin()
    {
        if (hurting == true)
        {
            animator.SetInteger("Anim", 3);
            htimer += Time.deltaTime;
            if (htimer > 1)
            {
                htimer = 0;
                hurting = false;
            }
        }
        else if (scount > 0)
        {
            animator.SetInteger("Anim", 2);
        }
        else if (atime > 0)
        {
            animator.SetInteger("Anim", 1);
        }
    }

    private void Shoot()
    {
        if (HitPoints < MaxHitpoints * 0.5f)
        {
            factor = 0.13f * singleton.diA;
        }
        else
        {
          factor = 0.08f * singleton.diA;
        }
       
        float ranfactor = Random.Range(0, factor);
        counter += Time.deltaTime;
        if (counter >= 1.2 -(0.2f * singleton.diA) - ranfactor)
        {
            counter = 0;
            while (lastShot == randomnumberchosen)
            {
                randomnumberchosen = Random.Range(0, positions.Length);
            }
            lastShot = randomnumberchosen;
            ran1 = randomnumberchosen;
            Vector3 position = positions[randomnumberchosen].position;
            Instantiate(ball, position, Quaternion.identity);
            scount = scount - 1;
        }
    }
    public void att()
    {
        if (atime > 0)
        {
            atime = atime - 0.15f * singleton.diA;
        }
        AudioSource.PlayClipAtPoint(damageSFX, Camera.main.transform.position);
        Movement.pattack = true;
        HitPoints -= 10;
        if (HitPoints < MaxHitpoints * 0.5f)
        {
            HitPoints -= 9 - (1 * singleton.diA);
        }
        else
        {
            HitPoints -= 10;
        }
        hurting = true;
        hpBar.SetHealth(HitPoints, MaxHitpoints);
        Debug.Log("Current Hp: " + HitPoints);
        attk = false;
        if (HitPoints <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}
    

