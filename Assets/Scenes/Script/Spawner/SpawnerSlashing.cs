using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSlashing : MonoBehaviour
{
    [SerializeField] GameObject ball,bell;

    private float time = 0;

    private bool isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        isGameOver = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == true)
        {

            // �L�[����(�����Ă��)
            if (Input.GetMouseButton(0))
            {
               // Debug.Log("Time:" + time);

                // �o�ߎ��Ԃ̌v�Z
                time += Time.deltaTime;
                if (time < 1.0f)
                {

                }
                else if (time < 2.0f)
                {

                }
                else if (time < 5.0)
                {

                }
                else
                {
                    time = 0;
                    Invoke("ddd", 0.2f);
                    Invoke("aaa", 1.0f);
                }
            }

            // �L�[����(��������)
            if (Input.GetMouseButtonUp(0))
            {
                isGameOver = false;
                // ����
                if (time < 1.0f)
                {
                    Debug.Log("Tim");
                }
                else if (time < 2.0f)
                {
                    Invoke("ccc", 0.2f);
                }
                else
                {
                    Invoke("ddd", 0.2f);
                }
                Invoke("aaa", 1.0f);
                time = 0;
            }
        }
    }
    void aaa()
    {
        isGameOver = true;
    }
    void ccc()
    {
        Instantiate(ball, transform.position, transform.rotation);

    }
    void ddd()
    {
        Instantiate(bell, transform.position, transform.rotation);
    }
}