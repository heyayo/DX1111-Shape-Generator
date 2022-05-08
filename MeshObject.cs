using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class MeshObject : MonoBehaviour
{
    [SerializeField]
    MeshType meshType;

    [SerializeField]
    bool startAtOrigin = false;

    [SerializeField]
    float xScale = 1;

    [SerializeField]
    float yScale = 1;

    [SerializeField]
    float rotation = 0;

    [SerializeField]
    int resolution = 3;

    [SerializeField]
    Color color;

    Mesh mesh;

    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        if(startAtOrigin)
            transform.position = new Vector3(0, 0, 0);

        InitialiseMesh();

        GetComponent<Renderer>().material.color = color;
    }

    void InitialiseMesh()
    {
        mesh.Clear();

        MeshData meshData = MeshGenerator.GenerateShape(xScale, yScale, resolution, rotation);
        mesh.vertices = meshData.vertices;
        mesh.triangles = meshData.triangles;
        Debug.Log(meshData.vertices);
        Debug.Log(meshData.triangles);

    }
}