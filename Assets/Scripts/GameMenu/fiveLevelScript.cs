using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fiveLevelScript : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("5Level");
    }
}
