using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attak : MonoBehaviour
{
    [SerializeField] private GameObject a , b, c, d, e, f, g, h, i;
    //GameObject�^�̕ϐ�a��錾�@�D���ȃQ�[���I�u�W�F�N�g���A�^�b�`
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

            // �L�[����(�����Ă��)
            if (Input.GetMouseButton(0))
            {
                // �o�ߎ��Ԃ̌v�Z
                time += Time.deltaTime;
                if (time < 1.0f)
                {
                    moveSpeed = 14f;
                    a.SetActive(true);
                    // ���߂Ȃ�
                }
                else if (time < 2.0f)
                {
                    moveSpeed = 12f;
                    a.SetActive(false);
                    b.SetActive(true);
                    // �㗭�ߍU��
                }
                else if(time < 5.0)
                {
                    moveSpeed = 5f;
                    b.SetActive(false);
                    c.SetActive(true);
                    //�����ߍU��
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

            // �L�[����(��������)
            if (Input.GetMouseButtonUp(0))
            {
                isGameOver = false;
               // GetComponent<Animator>().SetTrigger("Trigger");
                // ����
                if (time < 1.0f)
                {
                    Debug.Log("1");
                    a.SetActive(false);
                    d.SetActive(true);
                    g.SetActive(true);
                    // ���߂Ȃ�
                }
                else if (time < 2.0f)
                {
                    Debug.Log("2");
                    b.SetActive(false);
                    e.SetActive(true);
                    h.SetActive(true);
                    // �㗭�ߍU��
                }
                else
                {
                    Debug.Log("3");
                    c.SetActive(false);
                    f.SetActive(true);
                    i.SetActive(true);
                    //�����ߍU��
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
        // �J�����̕�������AX-Z���ʂ̒P�ʃx�N�g�����擾
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

        // �����L�[�̓��͒l�ƃJ�����̌�������A�ړ�����������
        Vector3 moveForward = cameraForward * inputVertical + Camera.main.transform.right * inputHorizontal;

        // �ړ������ɃX�s�[�h���|����B�W�����v�◎��������ꍇ�́A�ʓrY�������̑��x�x�N�g���𑫂��B
        rb.velocity = moveForward * moveSpeed + new Vector3(0, rb.velocity.y, 0);

        // �L�����N�^�[�̌�����i�s������
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