using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyButton : MonoBehaviour
{
    public ShopManager _shop;

    private void OnMouseDown()
    {
        _shop.Buy();
    }
}
