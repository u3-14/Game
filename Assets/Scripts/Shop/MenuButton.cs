using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public ShopManager _shop;

    private void OnMouseDown()
    {
        _shop.GoBack();
    }
}
