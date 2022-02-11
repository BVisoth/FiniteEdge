using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class singleton : MonoBehaviour
{
    static public int diA;

    // Start is called before the first frame update
    void Start()
    {
        diA = 2;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Dia =" + diA);
        if(Dif_Test.easy == true)
        {
            diA = 0 + 1;
        }
        else if(Dif_Test.normal == true)
        {
            diA = 0 + 2;
        }
        else if (Dif_Test.hard == true)
        {
            diA = 0 + 3;
        }
    }
    public void dif1()
    {

    }
    public void dif2()
    {

    }
    public void dif3()
    {

    }
}

