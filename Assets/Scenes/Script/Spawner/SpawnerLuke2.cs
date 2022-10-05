using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLuke : MonoBehaviour
{
    [SerializeField] GameObject ball;

    private float time = 0;

    private bool isGameOver;

    //bulletプレハブ
    // public GameObject bullet;
    //弾が生成されるポジションを保有するゲームオブジェクト
    // public GameObject bulletPos;

    // Update is called once per frame
    void Start()
    {
        time = 0;
        isGameOver = true;
    }
    void Update()
    {
        time += Time.deltaTime;

        if (isGameOver == true)
        {
            if (time > 1)
            {
                isGameOver = false;
                Invoke("aaa", 0.3f);
                Instantiate(ball, transform.position, transform.rotation);
                time = 0;
            }
        }
    }
    void aaa()
    {
        isGameOver = true;
        time = 0;
    }
}
