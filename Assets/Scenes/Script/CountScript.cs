using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountScript : MonoBehaviour
{
    private bool isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Down");
                Invoke("bbb", 1.0f);
                if (Input.GetMouseButtonUp(0))
                {
                    Debug.Log("Up");
                    Invoke("aaa", 0.0f);
                }
            }
        }
    }
    void GetMouseButtonDown()
    {
        Debug.Log("1");
        CancelInvoke();
    }
    void bbb()
    {
        Debug.Log("2");
        Invoke("ccc", 1.0f);

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("AUp");
            Invoke("ddd", 0.0f);
        }
    }
    void ccc()
    {
        Debug.Log("3");
        CancelInvoke();
    }
    void ddd()
    {
        Debug.Log("4");
        CancelInvoke();
    }
}
