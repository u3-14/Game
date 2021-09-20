using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("PlayMenu");
    }
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }
    public void Settings()
    { 
        SceneManager.LoadScene("Settings");
    }
    public void Exit()
    { 
        Application.Quit();
    }
}
