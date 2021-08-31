using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class slevelScript : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("2Level");
    }
}
