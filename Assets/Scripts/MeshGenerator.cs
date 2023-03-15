using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(MeshFilter))]
public class MeshGenerator : MonoBehaviour
{
    public Button Refresh ;
    public float width;
    public float height;
    public float lenght;
    Mesh mesh;
    Vector3[] vertices;
    int[] triangles;
    
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        CreateShape();
        UpdateMesh();
    }
    void CreateShape()
    {
        vertices = new Vector3[]
        {
            new Vector3(0, 0, 0),
            new Vector3(0, 1 +height, 1 +lenght/2),
            new Vector3(1+width, 0, 0),
            new Vector3(1+width, 1 +height, 1+lenght/2),

            new Vector3(0, 0, 2 +lenght),
            new Vector3(1+width, 0, 2+lenght),

        };

        triangles = new int[]
        {
            0,1,2,
            1,3,2,

            1,4,3,
            4,5,3,
        };
    }
    void UpdateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            CreateShape();
            UpdateMesh();
        }
    }
    //debug
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        if (mesh != null) 
        {
            for (int i = 0; i < vertices.Length; i++)
            {

                //Gizmos.DrawWireSphere(vertices[i], 0.05f);
                Handles.Label(vertices[i], vertices[i].ToString());
            }
        
        }

    }
}
