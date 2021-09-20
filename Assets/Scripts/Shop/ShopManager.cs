using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{
    private int money = 0, skinNumber = 0;
    public int scins;
    public GameObject shop;
    public GameObject[] YesP;
    private bool[] buyed;
    private bool a = true;

    private void Start()
    {
        foreach (var i in YesP)
        {
            i.SetActive(false);
        }
        YesP[0].SetActive(true);
    }

    private void Update()
    {
        
    }

    public void Left()
    {
        if (skinNumber > 0 && a)
        {
            YesP[skinNumber].SetActive(false);
            skinNumber--;
            YesP[skinNumber].SetActive(true);
            StartCoroutine("ToLeftCorutine");
        } 
    }

    public void Right()
    {
        if (skinNumber < scins - 1 && a)
        {
            YesP[skinNumber].SetActive(false);
            skinNumber++;
            YesP[skinNumber].SetActive(true);
            StartCoroutine("ToRightCorutine");
        } 
    }

    public void Buy()
    {
        
    }

    IEnumerator ToRightCorutine()
    {
        a = false;
        Vector3 go = new Vector3(shop.transform.position.x, shop.transform.position.y, shop.transform.position.z);
        for (int i = 0; i < 40; i++)
        {
            go.x -= .75f;
            shop.transform.position = go;
            yield return .016f;
        }
        for (int i = 0; i < 20; i++)
        {
            go.x += .25f;
            shop.transform.position = go;
            yield return .016f;
        }

        a = true;
    }
    
    IEnumerator ToLeftCorutine()
    {
        a = false;
        Vector3 go = new Vector3(shop.transform.position.x, shop.transform.position.y, shop.transform.position.z);
        for (int i = 0; i < 40; i++)
        {
            go.x += .75f;
            shop.transform.position = go;
            yield return .016f;
        }
        for (int i = 0; i < 20; i++)
        {
            go.x -= .25f;
            shop.transform.position = go;
            yield return .016f;
        }

        a = true;
    }

    public void GoBack()
    {
        SceneManager.LoadScene("Menu");
    }
}
