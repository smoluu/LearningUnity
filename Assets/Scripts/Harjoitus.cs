using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harjoitus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float A = 2;
        float B = 3;
        float C = A * B;
        float D = A + B + C;
        C -= 2;
        A = 5;
        if (D > A + C)
        {
            B *= 5;
        }
        for (int i = 0; i < 10; i++)
        {
            A++;
        }
        nimi();
        Debug.Log(A);
        Debug.Log(B);
        Debug.Log(C);
        Debug.Log(D);


    }
    void nimi()
    {
        Debug.Log("Santeri Smolander");
    }




    /*
    int kokonaisluku = 1;
    float desimaaliluku = 1.2f;
    bool totuus = true;
    string teksti = "hei!";
    */

    public float liikenopeus = 2.5f;
    public float kaantonopeus = 180f;

    // Update is called once per frame
    void Update()
    {
        int vertical = 0;
        int horizontal = 0;

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
    }
}
