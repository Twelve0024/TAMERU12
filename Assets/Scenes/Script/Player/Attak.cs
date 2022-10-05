using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attak : MonoBehaviour
{
    [SerializeField] private GameObject a , b, c, d, e, f, g, h, i;
    //GameObject型の変数aを宣言　好きなゲームオブジェクトをアタッチ
    float inputHorizontal;
    float inputVertical;
    float moveSpeed = 0f;
    Rigidbody rb;
    private float time = 0;
    private bool isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = true;
        moveSpeed = 10f;
        rb = GetComponent<Rigidbody>();
        time = 0;
    }

    private void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");
        if (isGameOver == true)
        {

            // キー入力(押してる間)
            if (Input.GetMouseButton(0))
            {
                // 経過時間の計算
                time += Time.deltaTime;
                if (time < 1.0f)
                {
                    moveSpeed = 14f;
                    a.SetActive(true);
                    // 溜めない
                }
                else if (time < 2.0f)
                {
                    moveSpeed = 12f;
                    a.SetActive(false);
                    b.SetActive(true);
                    // 弱溜め攻撃
                }
                else if(time < 5.0)
                {
                    moveSpeed = 5f;
                    b.SetActive(false);
                    c.SetActive(true);
                    //強溜め攻撃
                }
                else
                {
                    moveSpeed = 10f;
                   // GetComponent<Animator>().SetTrigger("Trigger");
                    Debug.Log("3");
                    c.SetActive(false);
                    f.SetActive(true);
                    i.SetActive(true);
                    time = 0;
                    Invoke("bbb", 0.7f);
                    Invoke("aaa", 1.0f);
                }
            }

            // キー入力(離した時)
            if (Input.GetMouseButtonUp(0))
            {
                isGameOver = false;
               // GetComponent<Animator>().SetTrigger("Trigger");
                // 判定
                if (time < 1.0f)
                {
                    Debug.Log("1");
                    a.SetActive(false);
                    d.SetActive(true);
                    g.SetActive(true);
                    // 溜めない
                }
                else if (time < 2.0f)
                {
                    Debug.Log("2");
                    b.SetActive(false);
                    e.SetActive(true);
                    h.SetActive(true);
                    // 弱溜め攻撃
                }
                else
                {
                    Debug.Log("3");
                    c.SetActive(false);
                    f.SetActive(true);
                    i.SetActive(true);
                    //強溜め攻撃
                }
                moveSpeed = 10f;
                time = 0;
                Invoke("bbb", 0.7f);
                Invoke("aaa", 1.0f);
            }

            //Debug.Log("Time:" + time);
        }
    }
    void FixedUpdate()
    {
        // カメラの方向から、X-Z平面の単位ベクトルを取得
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

        // 方向キーの入力値とカメラの向きから、移動方向を決定
        Vector3 moveForward = cameraForward * inputVertical + Camera.main.transform.right * inputHorizontal;

        // 移動方向にスピードを掛ける。ジャンプや落下がある場合は、別途Y軸方向の速度ベクトルを足す。
        rb.velocity = moveForward * moveSpeed + new Vector3(0, rb.velocity.y, 0);

        // キャラクターの向きを進行方向に
        if (moveForward != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveForward);
        }
    }
    void aaa()
    {
       // GetComponent<Animator>().SetTrigger("Trigger1");
        isGameOver = true;
    }
    void bbb()
    {
        d.SetActive(false);
        e.SetActive(false);
        f.SetActive(false);
        g.SetActive(false);
        h.SetActive(false);
        i.SetActive(false);
    }
}