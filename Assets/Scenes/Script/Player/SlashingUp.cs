using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashingUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(-30, 0, 0);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.Rotate(30, 0, 0);
        }

    }
}
