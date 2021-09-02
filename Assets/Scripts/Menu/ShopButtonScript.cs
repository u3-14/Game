using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopButtonScript : MonoBehaviour
{
    private bool _IsMousePressed = false;
    void Start()
    {
        
    }
    
    void Update()
    {
        if (_IsMousePressed)
        {
            SceneManager.LoadScene("Shop");
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
