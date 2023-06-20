using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visibility : MonoBehaviour
{
    public GameObject videoRenderer;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void OnMouseDown()
    {
        if (videoRenderer.activeInHierarchy == true) 
            videoRenderer.SetActive(false);
        else
            videoRenderer.SetActive(true);
    }
}
