using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //GameObject�^�̕ϐ�a��錾�@�D���ȃQ�[���I�u�W�F�N�g���A�^�b�`
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

            // �L�[����(�����Ă��)
            if (Input.GetMouseButton(0))
            {
                // �o�ߎ��Ԃ̌v�Z
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

            // �L�[����(��������)
            if (Input.GetMouseButtonUp(0))
            {
                isGameOver = false;
                GetComponent<Animator>().SetTrigger("Trigger");
                // ����
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