using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slashing1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("bbb", 3.0f);
    }

    void bbb()
    {
        Destroy(gameObject);
    }
}
