using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singleton : MonoBehaviour
{
    static public int diA;
    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<singleton>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void dif1()
    {
        diA = 1;
    }
    public void dif2()
    {
        diA = 2;
    }
    public void dif3()
    {
        diA = 3;
    }
}
