using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectScinScript : MonoBehaviour
{
    public ShopManager shop;
    public int ID;

    private void OnMouseDown()
    {
        shop.SelectScin(ID);
    }
}
