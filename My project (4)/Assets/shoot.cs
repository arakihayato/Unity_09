using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public bool hit = false;
    public float speed = 5f;
    Rigidbody rigidbody ;
    // Start is called before the first frame update
    void Start()
    {//Rigidbody�ɃA�N�Z�X���ĕϐ��ɕێ����Ă���
        rigidbody = GetComponent<Rigidbody>();
    }


    void OnCollisionEnter(Collision collision)
    {
        hit = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (hit == false)
        {

            Vector3 force = new Vector3(0.0f, 0.0f, 10.0f);    // �͂�ݒ�
            rigidbody.AddForce(force);
        }// �͂�������

        

    }
}
