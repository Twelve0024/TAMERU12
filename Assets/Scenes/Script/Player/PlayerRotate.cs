using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 5, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -5, 0);
        }
    }
}