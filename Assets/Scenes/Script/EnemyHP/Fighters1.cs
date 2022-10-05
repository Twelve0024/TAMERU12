using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighters1 : MonoBehaviour
{
    [SerializeField] private GameObject a;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fighters1"))
        {
            a.SetActive(true);
        }
    }
}
