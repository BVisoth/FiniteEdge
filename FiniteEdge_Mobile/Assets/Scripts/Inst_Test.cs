using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inst_Test : MonoBehaviour
{

    [SerializeField] GameObject ball;
    public Transform Location;
    public float counter;
    public int ran;
    void Update()
    {
       

    }

    public void Shoot()
    {
        counter = 0;
        ran = Random.Range(1, 5);

        if (ran == 1)
        {
            leftleft();
        }
        else if (ran == 2)
        {
            left();
        }
        else if (ran == 3)
        {
            right();
        }
        else if (ran == 4)
        {
            rightright();
        }

    }

    private void leftleft()
    {
        if (Location.position.x == -7.5f)
        {
            Instantiate(ball, Location.position, Location.rotation);
        }
    }

    private void left()
    {
        if (Location.position.x == -2.5f)
        {
            Instantiate(ball, Location.position, Location.rotation);
        }
    }
    private void rightright()
    {
        if (Location.position.x == 2.5f)
        {
            Instantiate(ball, Location.position, Location.rotation);
        }
    }
    private void right()
    {
        if (Location.position.x == 7.5f)
        {
            Instantiate(ball, Location.position, Location.rotation);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Hp_Test.currentHp -= 1;
        Destroy(gameObject);
    }
}
