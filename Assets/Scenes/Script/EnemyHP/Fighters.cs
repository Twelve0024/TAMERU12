using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighters : MonoBehaviour
{
    [SerializeField] private GameObject a;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fighters"))
        {
            a.SetActive(true);
        }
    }
}
