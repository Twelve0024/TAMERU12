using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinker : MonoBehaviour
{
    public GameObject a;

    //GameObject�^�̕ϐ�a��錾�@�D���ȃQ�[���I�u�W�F�N�g���A�^�b�`
    private float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }
    void OnCollisionEnter(Collision hit)
    {
        // �ڐG�����I�u�W�F�N�g�̃^�O��"Player"�̏ꍇ
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
