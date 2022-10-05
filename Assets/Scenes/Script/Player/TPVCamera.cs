using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class TPVCamera : MonoBehaviour
{
    public Transform Target;
    public float DistanceToPlayerM = 2f;    // �J�����ƃv���C���[�Ƃ̋���[m]
    public float SlideDistanceM = -0f;       // �J���������ɃX���C�h������G�v���X�̎��E�ցC�}�C�i�X�̎�����[m]
    public float HeightM = 1.2f;            // �����_�̍���[m]
    public float RotationSensitivity = 130f;// ���x

    void Start()
    {
        if (Target == null)
        {
            Debug.LogError("�^�[�Q�b�g���ݒ肳��Ă��Ȃ�");
            Application.Quit();
        }
    }

    void FixedUpdate()
    {
        var rotX = Input.GetAxis("Mouse X") * Time.deltaTime * RotationSensitivity;
        var rotY = Input.GetAxis("Mouse Y") * Time.deltaTime * RotationSensitivity;

        var lookAt = Target.position + Vector3.up * HeightM;

        // ��]
        transform.RotateAround(lookAt, Vector3.up, rotX);
        // �J�������v���C���[�̐^���^���ɂ���Ƃ��ɂ���ȏ��]�����Ȃ��悤�ɂ���
        if (transform.forward.y > 0.3f && rotY < 0)
        {
            rotY = 0;
        }
        if (transform.forward.y < -0.5f && rotY > 0)
        {
            rotY = 0;
        }
        transform.RotateAround(lookAt, transform.right, rotY);

        // �J�����ƃv���C���[�Ƃ̊Ԃ̋����𒲐�
        transform.position = lookAt - transform.forward * DistanceToPlayerM;

        // �����_�̐ݒ�
        transform.LookAt(lookAt);

        // �J���������ɂ��炵�Ē������J����
        transform.position = transform.position + transform.right * SlideDistanceM;
    }
}