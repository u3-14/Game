using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toLeftButton : MonoBehaviour
{
    public ShopManager _shop;
    
    private void OnMouseDown()
    {
        _shop.Right();
    }
}
