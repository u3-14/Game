using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButtonScript : MonoBehaviour
{
    private bool _IsMousePressed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_IsMousePressed)
        {
            Application.Quit();
        }
    }
    
    void OnMouseDown()
    {
        _IsMousePressed = true;
    }

    void OnMouseUp()
    {
        _IsMousePressed = false;
    }
}
