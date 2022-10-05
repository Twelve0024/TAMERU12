using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner3 : MonoBehaviour
{
    private float time = 0.5f;
    //bullet�v���n�u
    public GameObject bullet;
    //�e�����������|�W�V������ۗL����Q�[���I�u�W�F�N�g
    public GameObject bulletPos;
    //�e�̃X�s�[�h
    public float speed = 1500f;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        //�X�y�[�X�������ꂽ�Ƃ�
        if (time > 1)
        {
            time = 0.0f;
            //ball���C���X�^���X�����Ĕ���
            GameObject createdBullet = Instantiate(bullet) as GameObject;
            createdBullet.transform.position = bulletPos.transform.position;

            //���˃x�N�g��
            Vector3 force;
            //���˂̌����Ƒ��x������
            force = bulletPos.transform.forward * speed;
            // Rigidbody�ɗ͂������Ĕ���
            createdBullet.GetComponent<Rigidbody>().AddForce(force);
        }
    }
}