using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE2 : MonoBehaviour
{
    private Rigidbody rb;
    private float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 30.0f;
    }

    void Update()
    {
        rb.velocity = transform.forward * speed;
    }
}