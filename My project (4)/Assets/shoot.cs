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
    {//Rigidbodyにアクセスして変数に保持しておく
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

            Vector3 force = new Vector3(0.0f, 0.0f, 10.0f);    // 力を設定
            rigidbody.AddForce(force);
        }// 力を加える

        

    }
}
