using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lucks : MonoBehaviour
{
    [SerializeField] private GameObject a;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lucks"))
        {
            a.SetActive(true);
        }
    }
}
