using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{

    public GameObject camu;
    public GameObject camd;
    private bool isBeingHeld = false;

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Q) && isBeingHeld == false)
        {
            camd.SetActive(false);
            camu.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.E) && isBeingHeld == false)
        {
            camu.SetActive(false);
            camd.SetActive(true);
        }

    }

    private void OnMouseDown()
    {

        if (Input.GetMouseButtonDown(0))
        {
            isBeingHeld = true;
        }

    }

    private void OnMouseUp()
    {

        isBeingHeld = false;
        
    }

}
