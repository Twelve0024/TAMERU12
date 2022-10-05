using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOSS : MonoBehaviour
{
    private GameObject[] enemyBox;
    public GameObject a, b;

    void Update()
    {
        enemyBox = GameObject.FindGameObjectsWithTag("BOSS");

        print("ìGÇÃêîÅF" + enemyBox.Length);

        if (enemyBox.Length == 1)
        {
            a.SetActive(true);
            b.SetActive(true);
        }
    }
}