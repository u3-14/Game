using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fourLevelScript : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("4Level");
    }
}
