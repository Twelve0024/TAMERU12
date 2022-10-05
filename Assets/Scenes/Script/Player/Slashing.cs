using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slashing : MonoBehaviour
{
    MeshCollider sphereCol;
    // Start is called before the first frame update
    void Start()
    {
        sphereCol = GetComponent<MeshCollider>();
        Invoke("aaa", 0.1f);
        Invoke("bbb", 1.0f);
    }
    void aaa()
    {
        sphereCol.enabled = true;
    }
    void bbb()
    {
        Destroy(gameObject);
    }
}
