using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack_test : MonoBehaviour
{
    //inside class
    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;


    private void Update()
    {
        Swipe();
        Swipe2();
    }

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
                }
                //swipe down
                if (currentSwipe.y < 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
             {
                    Debug.Log("down swipe");
                }
                //swipe left
                if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
             {
                    Debug.Log("left swipe");
                }
                //swipe right
                if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
             {
                    Debug.Log("right swipe");
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
            }
            //swipe down
            if (currentSwipe2.y < 0 && currentSwipe2.x > -0.5f && currentSwipe2.x < 0.5f)
        {
                Debug.Log("down swipe");
            }
            //swipe left
            if (currentSwipe2.x < 0 && currentSwipe2.y > -0.5f && currentSwipe2.y < 0.5f)
        {
                Debug.Log("left swipe");
            }
            //swipe right
            if (currentSwipe2.x > 0 && currentSwipe2.y > -0.5f && currentSwipe2.y < 0.5f)
        {
                Debug.Log("right swipe");
            }
        }
    }
