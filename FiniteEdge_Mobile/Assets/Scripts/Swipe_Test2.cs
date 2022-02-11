using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe_Test2 : MonoBehaviour
{
   
    public int attackd;
    public bool breaker = true;
    public bool lattack;
    public bool rattack;
    public bool dattack;
    public bool uattack;

    public GameObject target;
    public GameObject leftarrow;
    public GameObject rightarrow;
    public GameObject uparrow;
    public GameObject downarrow;
    
    GameObject templeftarrow;
    GameObject temprightarrow;
    GameObject tempuparrow;
    GameObject tempdownarrow;

    //inside class
    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;

    

    public void Swipe()
    {
        if (Input.touches.Length > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Began)
            {
                //save began touch 2d point
                firstPressPos = new Vector2(t.position.x, t.position.y);
            }
            if (t.phase == TouchPhase.Ended)
            {
                //save ended touch 2d point
                secondPressPos = new Vector2(t.position.x, t.position.y);

                //create vector from the two points
                currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

                //normalize the 2d vector
                currentSwipe.Normalize();

                //swipe upwards
                if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
                {
                    Debug.Log("up swipe");
                    uattack = true;
                }
                //swipe down
                if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
                {
                    Debug.Log("down swipe");
                    dattack = true;
                }
                //swipe left
                if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                {
                    Debug.Log("left swipe");
                    lattack = true;
                }
                //swipe right
                if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                {
                    Debug.Log("right swipe");
                    rattack = true;
                }
            }
        }
    }
    Vector2 firstPressPos2;
    Vector2 secondPressPos2;
    Vector2 currentSwipe2;

    public void Swipe2()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //save began touch 2d point
            firstPressPos2 = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
        if (Input.GetMouseButtonUp(0))
        {
            //save ended touch 2d point
            secondPressPos2 = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            //create vector from the two points
            currentSwipe2 = new Vector2(secondPressPos2.x - firstPressPos2.x, secondPressPos2.y - firstPressPos2.y);

            //normalize the 2d vector
            currentSwipe2.Normalize();

            //swipe upwards
            if (currentSwipe2.y > 0 && currentSwipe2.x > -0.5f && currentSwipe2.x < 0.5f)
            {
                Debug.Log("up swipe");
                uattack = true;
            }
            //swipe down
            if (currentSwipe2.y < 0 && currentSwipe2.x > -0.5f && currentSwipe2.x < 0.5f)
            {
                Debug.Log("down swipe");
                dattack = true;
            }
            //swipe left
            if (currentSwipe2.x < 0 && currentSwipe2.y > -0.5f && currentSwipe2.y < 0.5f)
            {
                Debug.Log("left swipe");
                lattack = true;
            }
            //swipe right
            if (currentSwipe2.x > 0 && currentSwipe2.y > -0.5f && currentSwipe2.y < 0.5f)
            {
                Debug.Log("right swipe");
                rattack = true;
            }
        }
    }
    private void Start()
    {
        breaker = true;
    }

    void Update()
    {
        if (BossPreset.atime > 0)
        {
            Debug.Log("Atime");
            Dir();
            Debug.Log("attackd"+attackd);

           
        }
        if (BossPreset.atime > 0)
        {
            Swipe();
            Swipe2();
        }



    }
    void Dir()
    {

        Vector3 position = target.transform.position;

        Debug.Log("Breaker = " + breaker);
        if (breaker == true)
        {
            attackd = Random.Range(1, 5);
            Debug.Log("Apple");
        }
        {

            //This Section is for the directions where the player needs to attack via arrows that will be added. For now the indicators will be in the debug log.
            if (attackd == 1)
            {
                breaker = false;
                Debug.Log("Go Left!");
                templeftarrow = Instantiate(leftarrow, position, Quaternion.identity);
                if (lattack == true)
                {
                    lattack = false;
                    BossPreset.attk = true;
                    breaker = true;
                    Destroy(templeftarrow);
                }


            }
            else if (attackd == 2)
            {
                breaker = false;
                Debug.Log("Go Right!");
                temprightarrow = Instantiate(rightarrow, position, Quaternion.identity);
                if (rattack == true)
                {
                    rattack = false;
                    BossPreset.attk = true;
                    breaker = true;
                    Destroy(temprightarrow);
                }

            }
            else if (attackd == 3)
            {
                breaker = false;
                Debug.Log("Go Up!");
                tempuparrow = Instantiate(uparrow, position, Quaternion.identity);
                if (uattack == true)
                {
                    uattack = false;
                    BossPreset.attk = true;
                    breaker = true;
                    Destroy(tempuparrow);

                }
            }
            else if (attackd == 4)
            {
                breaker = false;
                Debug.Log("Go Down!");
                tempdownarrow = Instantiate(downarrow, position, Quaternion.identity);
                if (dattack == true)
                {
                    dattack = false;
                    BossPreset.attk = true;
                    breaker = true;
                    Destroy(tempdownarrow);

                }
            }


        }

    }
    
}
