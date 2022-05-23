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
    bool isStar = false;
	
	// Intialization Values
    [SerializeField]
    public float InitialxScale = 1;
    [SerializeField]
    public float InitialyScale = 1;
    [SerializeField]
    public float Initialrotation = 0;
    [SerializeField]
    int resolution = 3;
    [SerializeField]
    Color Initialcolor;

    Mesh mesh;
	
	[SerializeField]
	bool scaling = false;
	[SerializeField]
	float xScaleRate = 0;
	[SerializeField]
	float yScaleRate = 0;

    [SerializeField]
    Transform parent;

    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        if(startAtOrigin)
            transform.position = new Vector3(0, 0, 0);

        transform.parent = parent;
        InitialiseMesh();

        GetComponent<Renderer>().material.color = Initialcolor;
    }

    void InitialiseMesh()
    {
        mesh.Clear();

        MeshData meshData = MeshGenerator.GenerateShape(InitialxScale, InitialyScale, resolution, Initialrotation, isStar);
        mesh.vertices = meshData.vertices;
        mesh.triangles = meshData.triangles;
    }

    void FixedUpdate()
    {
		if (scaling)
		{
			transform.localScale += new Vector3(xScaleRate,yScaleRate);
		}
    }
}
