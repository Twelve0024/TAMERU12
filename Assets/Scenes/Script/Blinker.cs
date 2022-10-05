using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinker : MonoBehaviour
{
    public GameObject a;

    //GameObject型の変数aを宣言　好きなゲームオブジェクトをアタッチ
    private float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }
    void OnCollisionEnter(Collision hit)
    {
        // 接触したオブジェクトのタグが"Player"の場合
        if (hit.gameObject.CompareTag("death"))
        {
            time += Time.deltaTime;

            if (time < 0.2f)
            {
                a.SetActive(false);
                Invoke("aaa", 0.2f);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
    void aaa()
    {
        a.SetActive(true);
    }
}
