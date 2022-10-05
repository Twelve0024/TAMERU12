using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterHP : MonoBehaviour
{
    public GameObject a,b;
    float HP = 0;
    void Start()
    {
        HP = 3;
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
            Destroy(this.gameObject);
        }
        if (HP == 1)
        {
            a.SetActive(true);
            b.SetActive(false);
        }
        else if (HP == 2)
        {
            b.SetActive(true);
        }
    }
}