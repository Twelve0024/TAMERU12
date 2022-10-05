using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //GameObject型の変数aを宣言　好きなゲームオブジェクトをアタッチ
    private float time = 0;
    private bool isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = true;
        time = 0;
    }

    private void Update()
    {
        if (isGameOver == true)
        {

            // キー入力(押してる間)
            if (Input.GetMouseButton(0))
            {
                // 経過時間の計算
                time += Time.deltaTime;
                if (time < 1.0f)
                {

                }
                else if (time < 2.0f)
                {

                }
                else if(time < 5.0)
                {

                }
                else
                {
                    GetComponent<Animator>().SetTrigger("Trigger");
                    time = 0;
                    Invoke("aaa", 1.0f);
                }
            }

            // キー入力(離した時)
            if (Input.GetMouseButtonUp(0))
            {
                isGameOver = false;
                GetComponent<Animator>().SetTrigger("Trigger");
                // 判定
                if (time < 1.0f)
                {

                }
                else if (time < 2.0f)
                {

                }
                else
                {

                }
                time = 0;
                Invoke("aaa", 1.0f);
            }

            //Debug.Log("Time:" + time);
        }
    }
    void aaa()
    {
        GetComponent<Animator>().SetTrigger("Trigger1");
        isGameOver = true;
    }

}