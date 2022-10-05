using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager1 : MonoBehaviour
{
    private GameObject[] enemyBox;
    public GameObject a;

    void Update()
    {
        enemyBox = GameObject.FindGameObjectsWithTag("Enemy1");

        print("ìGÇÃêîÅF" + enemyBox.Length);

        if (enemyBox.Length == 0)
        {
            a.SetActive(true);
        }
    }
}