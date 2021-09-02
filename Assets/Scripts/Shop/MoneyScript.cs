using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour
{
    public ulong _MoneyCheck = 0;
    private Text _text;

    private void Start()
    {
        _text = GetComponent<Text>();
    }

    private void Update()
    {
        _text.text = _MoneyCheck.ToString();
    }
}
