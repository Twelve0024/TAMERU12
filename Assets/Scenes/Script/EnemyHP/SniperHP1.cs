using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperHP1 : MonoBehaviour
{
    [SerializeField] private GameObject a , b , c;

    float HP = 0;
    void Start()
    {
        HP = 2;
    }

    //OnTriggerEnter関数
    //接触したオブジェクトが引数otherとして渡される
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("1"))
        {
            HP -= 1;
        }
        if (other.CompareTag("2"))
        {
            HP -= 2;
        }
        if (other.CompareTag("3"))
        {
            HP -= 3;
        }
    }
    void Update()
    {
        if (HP < 1)
        {
            a.SetActive(false);
            b.SetActive(false);
            Invoke("aaa", 20.0f);
        }
        if (HP == 1)
        {
            c.SetActive(true);
        }
        else
        {
            c.SetActive(false);
        }
    }
    void aaa()
    {
        HP = 2;
        a.SetActive(true);
        b.SetActive(true);
    }
}