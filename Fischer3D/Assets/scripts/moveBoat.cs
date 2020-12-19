using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBoat : MonoBehaviour
{
    public Rigidbody rb;
    public float thrust;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, 1, transform.position.z);
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = transform.forward * thrust;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = -transform.forward * thrust/2;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 3,0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -3,0);
        }
    }
}
