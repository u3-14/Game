using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    public GameObject joystick;
    void Start()
    {
        
    }
    
    void Update()
    {
        Vector3 position = new Vector3(transform.position.x + joystick.GetComponent<DynamicJoystick>().Direction.x / 5,
            transform.position.y + joystick.GetComponent<DynamicJoystick>().Direction.y / 5, transform.position.z);
        transform.position = position;
    }
}
