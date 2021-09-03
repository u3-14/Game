using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtonManager : MonoBehaviour
{
    public void L1()
    {
        SceneManager.LoadScene("1Level");
    }
    public void L2()
    {
        SceneManager.LoadScene("2Level");
    }
    public void L3()
    {
        SceneManager.LoadScene("3Level");
    }
    public void L4()
    {
        SceneManager.LoadScene("4Level");
    }
    public void L5()
    {
        SceneManager.LoadScene("5Level");
    }
    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}
