using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    private int money = 0, skinNumber = 0;
    public GameObject[] skins;
    private Animator[] goToAnim;
    private bool[] buyed;

    private void Start()
    {
        for(int i = 0; i < skins.Length; i++)
        {
            goToAnim[i] = skins[i].GetComponent<Animator>();
        }
    }

    private void Update()
    {
        
    }

    public void Left()
    {
        
    }

    public void Right()
    {
        
    }

    public void Buy()
    {
        
    }
}
