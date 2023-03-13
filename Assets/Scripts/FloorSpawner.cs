using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class FloorSpawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    public Camera debugCamera;
    public Vector3 firstPosition;
    public int spawnCount = 10;
    public int destroyAfterSpawnAmount = 10;
    public List<Color> Colors = new List<Color>();

    private Vector3 spawnPosition;

    public float spawnInterval = 1f; //seconds
    float timer = 0;
    int spawnID = 0;

    float gap;
    float currentWidth;
    float previousWidth;
    public List<GameObject> spawnsList;

    void Start()
    {   
        spawnPosition = firstPosition;
    }

    void Update()
    {

        //spawn interval
        timer += Time.deltaTime;

        if (timer >= spawnInterval && spawnID < spawnCount) {
            int randomIndex = Random.Range(0, objectsToSpawn.Length); //get random index from objectsToSpawn array
            currentWidth = objectsToSpawn[randomIndex].GetComponent<Renderer>().bounds.size.z;// set gap to width of object collider

            //set gap between current object and previous object 
            if (spawnID > 0)
            {
                previousWidth = spawnsList[spawnID - 1].GetComponent<Renderer>().bounds.size.z;
            } else { previousWidth = 0; }
            gap = (currentWidth + previousWidth) / 2;

            spawnPosition += new Vector3(0, 0, gap);

            spawnsList.Add((GameObject)Instantiate(objectsToSpawn[randomIndex], spawnPosition, Quaternion.identity));
            spawnsList[spawnID].GetComponent<MeshRenderer>().material.color = Colors[Random.Range(0, Colors.Count)]; //assign random color
            spawnsList[spawnID].name = "spawn" + spawnID;


            //move debug camera
            //if (debugCamera.scene.IsValid())
            {
                debugCamera.transform.position += new Vector3(0,0,previousWidth);
            }

            timer -= spawnInterval;
            spawnID++;
            if(spawnID >= destroyAfterSpawnAmount)
            {
                Destroy(spawnsList[spawnID - destroyAfterSpawnAmount - 1]);
            }
        }
    }
}
