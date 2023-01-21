using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickRotationPoint : MonoBehaviour
{
    public GameObject MineBall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = MineBall.transform.position;
    }
}
