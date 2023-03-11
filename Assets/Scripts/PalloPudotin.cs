using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalloPudotin : MonoBehaviour
{
    public GameObject pallo;
    public Transform target;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
           GameObject go = Instantiate(pallo,target.position,Quaternion.identity);
            //go.GetComponent<Rigidbody>().AddForce(Vector3.forward * 100);
        }
    }
}
