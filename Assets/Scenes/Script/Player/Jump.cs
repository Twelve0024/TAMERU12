using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;//  Rigidbody���g�����߂̕ϐ�
    private bool Grounded;//  �n�ʂɒ��n���Ă��邩���肷��ϐ�
    public float Jumppower;//  �W�����v��

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();//  rb��Rigidbody�̒l��������
    }

    // Update is called once per frame
    void Update()
    {
        if (Grounded == true)//  �����AGrounded��true�Ȃ�A
        {
            if (Input.GetKeyDown(KeyCode.Space))//  �����A�X�y�[�X�L�[�������ꂽ�Ȃ�A  
            {
                Grounded = false;//  Grounded��false�ɂ���
                rb.AddForce(Vector3.up * Jumppower);//  ���JumpPower���͂�������
            }
        }
    }

    void OnCollisionEnter(Collision other)//  �n�ʂɐG�ꂽ���̏���
    {
        if (other.gameObject.tag == "Ground")//  ����Ground�Ƃ����^�O�������I�u�W�F�N�g�ɐG�ꂽ��A
        {
            Grounded = true;//  Grounded��true�ɂ���
        }
    }
}