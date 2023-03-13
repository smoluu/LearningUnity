using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class FloorSpawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    public List<Color> Colors = new List<Color>();
    public List<GameObject> spawnsList;
    public Camera debugCamera;
    public Vector3 firstPosition;
    private Vector3 spawnPosition;
    public int spawnCount = 10;
    public int destroyAfterSpawnAmount = 10;
    public float spawnInterval = 1f; //seconds


    float timer = 0;
    int spawnID = 0;

    float gap;
    float previousWidth;
    float currentWidth;

    void Start()
    {   
        spawnPosition = firstPosition;
    }

    void Update()
    {

        //spawn interval
        timer += Time.deltaTime;

        if (timer >= spawnInterval &&
            spawnID < spawnCount &&
            objectsToSpawn.Length > 0) 
            {
            //get random index from objectsToSpawn array
            int randomIndex = Random.Range(0, objectsToSpawn.Length); 
            

            //set gap between current object and previous object 
            currentWidth = objectsToSpawn[randomIndex].GetComponent<Renderer>().bounds.size.z;
            if (spawnID > 0)
            {
                previousWidth = spawnsList[spawnID - 1].GetComponent<Renderer>().bounds.size.z;
            } else { previousWidth = 0; }
            gap = (currentWidth + previousWidth) / 2;
            spawnPosition += new Vector3(0, 0, gap);

            //add object to list and instantiate
            spawnsList.Add((GameObject)Instantiate(objectsToSpawn[randomIndex], spawnPosition, transform.rotation, transform)); 
            
            //assign random color to spawned object
            if(Colors.Count > 0)
            {
            spawnsList[spawnID].GetComponent<MeshRenderer>().material.color = Colors[Random.Range(0, Colors.Count)]; 
            }
            spawnsList[spawnID].name = "spawn" + spawnID;


            //move debug camera
            if (debugCamera != null)
            {
                debugCamera.transform.position += new Vector3(0,0,previousWidth);
            }

            timer -= spawnInterval;
            spawnID++;
            // destroy objects
            if(spawnID >= destroyAfterSpawnAmount+ 1)
            {
                Destroy(spawnsList[spawnID - destroyAfterSpawnAmount - 1]);
            }
        }
    }
}
