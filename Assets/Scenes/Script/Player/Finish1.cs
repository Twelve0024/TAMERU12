using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish1 : MonoBehaviour
{
    [SerializeField] private GameObject a, b;
    private float count = 0;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (count < 3)
        {
            if (Input.GetMouseButtonDown(1))
            {
                a.SetActive(true);
                b.SetActive(true);
                Invoke("aaa", 0.3f);
                Invoke("bbb", 0.1f);
            }
        }
    }
    void aaa()
    {
        b.SetActive(false);
    }
    void bbb()
    {
        Instantiate(a, transform.position, transform.rotation);
    }

}
