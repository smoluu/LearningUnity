using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    Rigidbody rb;
    public float jumpForce;
    public float liikenopeus = 2.5f;
    public float kaantonopeus = 180f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
        int vertical = 0;
        int horizontal = 0;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce);
        }

        if (Input.GetKey(KeyCode.W))
        {
            vertical = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            vertical = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            horizontal = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            horizontal = 1;
        }

        transform.position += transform.forward * vertical * Time.deltaTime * liikenopeus;

        transform.eulerAngles += new Vector3(0, horizontal, 0) * Time.deltaTime * kaantonopeus;

        vertical = 0;
        horizontal = 0;
    }
}
