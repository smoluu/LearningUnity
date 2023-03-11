using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kolikko : MonoBehaviour
{
    public string SoundCollect;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            GameManager GM = FindObjectOfType<GameManager>();
            GM.addScore();
            FindObjectOfType<AudioManager>().Play("Collect0"); //Ääni
            Destroy(gameObject);
        }
    }
}
