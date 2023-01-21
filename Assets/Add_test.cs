using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_test : MonoBehaviour
{
    public GameObject startBall;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = startBall.GetComponent<Rigidbody>();  // rigidbodyを取得
        Vector3 force = new Vector3(1000.0f, 0.0f, 0.0f);    // 力を設定
        rb.AddForce(force);  // 力を加える
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
