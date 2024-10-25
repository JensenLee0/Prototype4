using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMove : MonoBehaviour
{
    public Rigidbody laserRb;
    public float movespeed;

    // Start is called before the first frame update
    void Start()
    {
        laserRb = GetComponent<Rigidbody>();
        laserRb.AddForce(Vector3.forward * movespeed, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
