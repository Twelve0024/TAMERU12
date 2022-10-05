using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaayerWaepon : MonoBehaviour
{
    private bool isGameOver;

    void Start()
    {
        isGameOver = true;
    }

    void Update()
    {
        if (isGameOver == true)
        {
            if (Input.GetMouseButtonUp(0))
            {
                isGameOver = false;

                GetComponent<Animator>().SetTrigger("Trigger");

                Invoke("DelayMethod", 1.0f);
            }
        }
    }
    void DelayMethod()
    {
        GetComponent<Animator>().SetTrigger("Trigger1");
        isGameOver = true;
    }
}
