using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Idou : MonoBehaviour
{
    public GameObject Camera0;
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject Camera4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    KeyCode key1 = KeyCode.C;
    KeyCode key2 = KeyCode.V;
    KeyCode key3 = KeyCode.B;
    KeyCode key4 = KeyCode.N;
    KeyCode key5 = KeyCode.M;
    void Update()
    {
        if (Input.GetKeyDown(key1))
        {
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera0.SetActive(true);
        }
        if (Input.GetKeyDown(key2))
        {
            Camera0.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera1.SetActive(true);
        }
        if (Input.GetKeyDown(key3))
        {
            Camera1.SetActive(false);
            Camera0.SetActive(false);
            Camera3.SetActive(false);
            Camera4.SetActive(false);
            Camera2.SetActive(true);
        }
        if (Input.GetKeyDown(key4))
        {
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera0.SetActive(false);
            Camera4.SetActive(false);
            Camera3.SetActive(true);
        }
        if (Input.GetKeyDown(key5))
        {
            Camera1.SetActive(false);
            Camera2.SetActive(false);
            Camera3.SetActive(false);
            Camera0.SetActive(false);
            Camera4.SetActive(true);
        }
    }
}
