using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SkinsData {
    public bool[] boughtSkins;

    public SkinsData(bool[] a)
    {
        boughtSkins = new bool[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            boughtSkins[i] = a[i];
        }
    }
}
