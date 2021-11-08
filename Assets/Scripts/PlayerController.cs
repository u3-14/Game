using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int scins;
    private int ID;
    
    
    void Start()
    {
        ID = SaveSystem.LoadScinID();
        transform.GetChild(ID).gameObject.SetActive(true);
    }

    
    void Update()
    {
        
    }
}
