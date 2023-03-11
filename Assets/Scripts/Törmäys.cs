using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Törmäys : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("OSUMA");
            FindObjectOfType<AudioManager>().Play("hit");

        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("OnCollisionStay");
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("OnCollisionExit");
        }
    }
}
