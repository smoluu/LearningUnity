using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTehtava : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //1
        if (Input.GetKeyDown(KeyCode.A)) {
            Debug.Log("a:ta painettu");
        }
        //2
        if (Input.GetKeyDown(KeyCode.A) &&
            Input.GetKeyDown(KeyCode.LeftShift)) {
            Debug.Log("shift + a painettu");
        }
        //3
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("space:a painettu");
        }
        //4
        float horizontal = Input.GetAxis("Horizontal");
        Debug.Log("Horizontal " + horizontal);
        //5
        if (Input.GetKeyDown(KeyCode.Keypad1)) {
            Debug.Log("Pad 1");
        }
        //6
        if (Input.GetKeyDown(KeyCode.Alpha2)){
            Debug.Log("Kaksi");
        }
        //7
        if (Input.GetKeyUp(KeyCode.F) &&
            !Input.GetKey(KeyCode.G))
        {
            Debug.Log("f - g");
        }

    }
}
