using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DressButton : MonoBehaviour
{
    public ChangeManager changeManager;

    private void OnMouseDown()
    {
        changeManager.OnOff();
    }
}
