using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(MeshFilter))]
public class MeshGenerator : MonoBehaviour
{
    public Button Refresh ;
    [SerializeField]
    [Range(1f, 10f)] public float width;
    [Range(1f, 10f)]
    [SerializeField] public float height;
    [Range(1f,10f)]
    [SerializeField] public float lenght;
    Mesh mesh;
    Vector3[] vertices;
    int[] triangles;
    List<Vector3> normals;
    
    
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        
        
    }
    public void CreateShape()
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
        List<Vector3> normals = new List<Vector3>() { 
            new Vector3(0,0,1),
            new Vector3(0,0,1),
            new Vector3(0,0,1),
            new Vector3(0,0,1),
            new Vector3(0,0,1),
            new Vector3(0,0,1)
           
        };
    }
    void UpdateMesh()
    {
        mesh.Clear();
        mesh.SetVertices( vertices );
        mesh.triangles = triangles;
        //mesh.SetNormals( normals );
        mesh.RecalculateNormals();
    }

    private void Update()
    {
        CreateShape();
        UpdateMesh();

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
