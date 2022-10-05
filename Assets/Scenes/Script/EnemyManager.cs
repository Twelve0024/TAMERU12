using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    private GameObject[] enemyBox;
    public GameObject a , b , c , d , e;

    void Update()
    {
        enemyBox = GameObject.FindGameObjectsWithTag("Enemy");

        print("ìGÇÃêîÅF" + enemyBox.Length);

        if (enemyBox.Length == 0)
        {
            d.SetActive(false);
            e.SetActive(true);
        }
        else
        {
            d.SetActive(true);
            e.SetActive(false);
        }
        if (enemyBox.Length <= 1)
        {
            c.SetActive(true);
        }
        else
        {
            c.SetActive(false);
        }
        if (enemyBox.Length <= 2)
        {
            a.SetActive(true);
            b.SetActive(false);
        }
        else
        {
            a.SetActive(false);
            b.SetActive(true);
        }
    }
}