using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painovoima : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        rb.AddForce(Vector3.up * jumpForce);
        }
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity += Vector3.forward;
        }
    }
}
