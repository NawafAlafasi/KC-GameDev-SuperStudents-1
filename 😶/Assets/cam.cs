using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{

    public GameObject camu;
    public GameObject camd;

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Q))
        {
            camd.SetActive(false);
            camu.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            camu.SetActive(false);
            camd.SetActive(true);
        }

    }
}
