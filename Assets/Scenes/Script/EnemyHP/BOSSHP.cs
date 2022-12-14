using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOSSHP : MonoBehaviour
{
    public GameObject a , b;

    float HP = 0;
    void Start()
    {
        HP = 1;
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
            Destroy(this.gameObject);
            a.SetActive(false);
            b.SetActive(false);
        }
        if (HP == 1)
        {
            a.SetActive(true);
        }
    }
}