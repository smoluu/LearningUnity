using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satunnaisluku : MonoBehaviour
{
    public List<string> nimet = new List<string> {"A","B","C","D" };
    private void Start()
    {
    int satunnaisluku = Random.Range(0, 10);
        Debug.Log("Satunnaisluku: " + satunnaisluku);

        float randomFloat = Random.Range(0f,1f);
        Debug.Log("random float: " + randomFloat);

        Debug.Log(nimet[Random.Range(0, nimet.Count)]);
    }
    
}
