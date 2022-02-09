using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe_Test : MonoBehaviour
{
    public static bool atturn;
    public int attackd;

    private void Start()
    {
        atturn = false;
    }

    void Update()
    {
        if(BossPreset.atime > 0)
        {
            Debug.Log("Atime is over");
            atturn = true;
        }
        else
        {
            atturn = false;
        }

        if(atturn == true)
        {
            Dir();
        }


        void Dir()
        {
            attackd = Random.Range(1, 5);

            //This Section is for the directions where the player needs to attack via arrows that will be added. For now the indicators will be in the debug log.
            switch (attackd)
            {
                case 1:
                    Debug.Log("Go Left!");
                    atturn = false;
                    break;
                case 2:
                    Debug.Log("Go Right!");
                    atturn = false;
                    break;
                case 3:
                    Debug.Log("Go Up!");
                    atturn = false;
                    break;
                case 4:
                    Debug.Log("Go Down!");
                    atturn = false;
                    break;
                default:
                    atturn = false;
                    break;
            }

            atturn = false;
        }


    }
}
