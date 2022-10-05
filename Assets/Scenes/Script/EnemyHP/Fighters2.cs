using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighters2 : MonoBehaviour
{
    [SerializeField] GameObject ball;
    private GameObject[] enemyBox;

    private bool isGameOver;
    void Start()
    {
        isGameOver = true;
    }
    void Update()
    {
        enemyBox = GameObject.FindGameObjectsWithTag("Fighter1");

        if (isGameOver == true)
        {
            if (enemyBox.Length < 4)
            {
                isGameOver = false;
                Invoke("aaa", 0.0f);
                Instantiate(ball, transform.position, transform.rotation);
            }
        }
    }
    void aaa()
    {
        isGameOver = true;
    }
}
