using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 12;
        Vector3 velocity = gameObject.transform.rotation * new Vector3(0, 0, speed);
        gameObject.transform.position += velocity * Time.deltaTime;
    }
}
