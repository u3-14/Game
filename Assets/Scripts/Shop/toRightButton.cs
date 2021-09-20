using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toRightButton : MonoBehaviour
{
    public ShopManager _shop;
    
    private void OnMouseDown()
    {
        _shop.Left();
    }
}
