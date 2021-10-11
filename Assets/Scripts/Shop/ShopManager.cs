using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    private int money, skinNumber = 0, scinID;
    public int scins;
    public GameObject shop, showScin, dressRoom;
    public GameObject[] YesP;
    public Text gold;
    private bool[] bought;
    private bool a = true;

    private void Start()
    {
        foreach (var i in YesP)
        {
            i.SetActive(false);
        }
        YesP[0].SetActive(true);
        
        money = SaveSystem.LoadMoney();
        bought = SaveSystem.LoadBuyingArray().boughtSkins;
        scinID = SaveSystem.LoadScinID();
        gold.text = money.ToString();
        for (int i = 0; i < bought.Length; ++i)
        {
            if (bought[i])
            {
                shop.transform.GetChild(i).GetChild(0).GameObject().SetActive(false);
                shop.transform.GetChild(i).GetChild(2).GameObject().SetActive(false);
                shop.transform.GetChild(i).GetChild(3).GameObject().SetActive(true);
                dressRoom.transform.GetChild(i).GetChild(1).GameObject().SetActive(false);
            }
            else
            {
                shop.transform.GetChild(i).GetChild(0).GameObject().SetActive(true);
                shop.transform.GetChild(i).GetChild(2).GameObject().SetActive(false);
                shop.transform.GetChild(i).GetChild(3).GameObject().SetActive(false);
            }
        }
        shop.transform.GetChild(scinID).GetChild(0).GameObject().SetActive(false);
        shop.transform.GetChild(scinID).GetChild(2).GameObject().SetActive(true);
        shop.transform.GetChild(scinID).GetChild(3).GameObject().SetActive(false);
        showScin.GetComponent<SpriteRenderer>().sprite = dressRoom.transform.GetChild(scinID).GetChild(0).GameObject()
            .GetComponent<SpriteRenderer>().sprite;
    }

    private void Update()
    {
        
    }

    public void Left()
    {
        if (skinNumber > 0 && a)
        {
            YesP[skinNumber--].SetActive(false);
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

    public void SelectScin(int ID)
    {
        Debug.Log(scinID);
        shop.transform.GetChild(scinID).GetChild(2).GameObject().SetActive(false);
        shop.transform.GetChild(scinID).GetChild(3).GameObject().SetActive(true);
        
        scinID = ID;
        
        showScin.GetComponent<SpriteRenderer>().sprite = dressRoom.transform.GetChild(scinID).GetChild(0).GameObject()
            .GetComponent<SpriteRenderer>().sprite;
        
        shop.transform.GetChild(scinID).GetChild(3).GameObject().SetActive(false);
        shop.transform.GetChild(scinID).GetChild(2).GameObject().SetActive(true);
        
        SaveSystem.SaveScinID(scinID);
    }

    public void Buy()
    {
        int ID = shop.transform.GetChild(skinNumber).GetChild(1).GetComponent<SkinData>().ID;
       int price = shop.transform.GetChild(skinNumber).GetChild(1).GetComponent<SkinData>().price;

       if (!bought[ID])
       {
           return;
       }

       if (money >= price)
       {
           bought[ID] = true;

           shop.transform.GetChild(scinID).GetChild(2).GameObject().SetActive(false);
           shop.transform.GetChild(scinID).GetChild(3).GameObject().SetActive(true);

           scinID = ID;
       
           shop.transform.GetChild(scinID).GetChild(0).GameObject().SetActive(false);
           shop.transform.GetChild(scinID).GetChild(2).GameObject().SetActive(true);

           money -= price;
           
           dressRoom.transform.GetChild(scinID).GetChild(1).GameObject().SetActive(false);
           showScin.GetComponent<SpriteRenderer>().sprite = dressRoom.transform.GetChild(scinID).GetChild(0).GameObject()
               .GetComponent<SpriteRenderer>().sprite;
           
           SaveSystem.SaveScinID(ID);
           SaveSystem.SaveBuyingArray(bought);
           SaveSystem.SaveMoney(money);
       }
       else
       {
           shop.transform.GetChild(ID).GameObject().GetComponent<Animator>().SetTrigger("Tr");
       }

       gold.text = money.ToString();
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
        SaveSystem.SaveMoney(money);
        SaveSystem.SaveBuyingArray(bought);
        SceneManager.LoadScene("Menu");
    }
}
