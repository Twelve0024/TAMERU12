using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GetComponent<Animator>().SetTrigger("Trigger");
            Invoke("aaa", 1.0f);
        }
    }
    void aaa()
    {
        GetComponent<Animator>().SetTrigger("Trigger1");
    }
}
