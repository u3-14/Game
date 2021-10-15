using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSaver : MonoBehaviour
{
    private static MusicSaver music;

    private void Awake()
    {
        if (music != null)
        {
            Destroy(gameObject);
        }
        else
        {
            music = this;
            DontDestroyOnLoad(transform.gameObject);
        }
    }
}
