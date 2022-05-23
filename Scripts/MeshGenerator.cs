using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct MeshData
{
    public string meshName;
    public Vector3[] vertices;
    public int[] triangles;
}

public enum MeshType
{
    MESH_TRIANGLE = 0,
    MESH_QUAD,
    MESH_PENTAGON,
    MESH_HEXAGON,
    MESH_HEPTAGON,
    MESH_OCTAGON,
    MESH_NANOGON,
    MESH_DECAGON,
    MESH_CIRCLE,
    MESH_OVAL,
    MESH_STAR
}

public class MeshGenerator
{
    public static MeshData GenerateShape(float xScale, float yScale, int res, float degrotate, bool star)
    {
        MeshData mesh = new MeshData();

        float switchAngle = (2 * Mathf.PI) / res;
        float rotation = degrotate * Mathf.Deg2Rad;

        if (star)
        {
            mesh.vertices = new Vector3[(res * 2) + 1];
            mesh.vertices[0] = new Vector3(0,0);
            for (int i = 0; i < res; i++)
            {
                mesh.vertices[i+1] = new Vector3(Mathf.Sin(switchAngle * i + rotation) * xScale, Mathf.Cos(switchAngle * i + rotation) * yScale);
            }
            for (int i = 0; i < res; i++)
            {
                mesh.vertices[res + i + 1] = new Vector3(Mathf.Sin((switchAngle / 2 + switchAngle * i) + rotation) * xScale * 2, Mathf.Cos((switchAngle / 2 + switchAngle * i) + rotation) * yScale * 2);
            }
        }
        else
        {
            mesh.vertices = new Vector3[res + 1];
            mesh.vertices[0] = new Vector3(0,0);
            for (int i = 0; i < res; i++)
            {
                mesh.vertices[i+1] = new Vector3(Mathf.Sin(switchAngle * i + rotation) * xScale, Mathf.Cos(switchAngle * i + rotation) * yScale);
            }
        }
        
        if (star)
        {
            mesh.triangles = new int[res * 6];

            for (int i = 0; i < res; i ++)
            {
                mesh.triangles[i * 6] = 0;
                mesh.triangles[(i * 6) + 1] = i + 1;
                mesh.triangles[(i * 6) + 2] = i + 1 + res;
                mesh.triangles[(i * 6) + 3] = 0;
                mesh.triangles[(i * 6) + 4] = i + 1 + res;
                if (i == res - 1)
                {
                    mesh.triangles[(i * 6) + 5] = 1;
                }
                else
                {
                    mesh.triangles[(i * 6) + 5] = i + 2;
                }
            }
        }
        else
        {
            mesh.triangles = new int[res * 3];

            for (int i = 0; i < res; i++)
            {
                mesh.triangles[i * 3] = 0;
                mesh.triangles[(i * 3) + 1] = i + 1;
                if (i == res - 1)
                {
                    mesh.triangles[(i * 3) + 2] = 1;
                }
                else
                {
                    mesh.triangles[(i * 3) + 2] = i + 2;
                }
            }
        }

        return mesh;
    }
    public static MeshData Generate(MeshType meshType)
    {
        switch(meshType)
        {
            //case MeshType.MESH_STAR:
            //    return GenerateStar();

            //case MeshType.MESH_OVAL:
            //    return GenerateOval();

            //case MeshType.MESH_CIRCLE:
            //    return GenerateCircle();

            //case MeshType.MESH_DECAGON:
            //    return GenerateDecagon();

            //case MeshType.MESH_NANOGON:
            //    return GenerateNanogon();

            //case MeshType.MESH_OCTAGON:
            //    return GenerateOctagon();

            //case MeshType.MESH_HEPTAGON:
            //    return GenerateHeptagon();

            //case MeshType.MESH_HEXAGON:
            //    return GenerateHexagon();

            //case MeshType.MESH_PENTAGON:
            //    return GeneratePentagon();

            //case MeshType.MESH_QUAD:
            //    return GenerateQuad();

            case MeshType.MESH_TRIANGLE:
            default:
                return GenerateTriangle();
        }
    }

    private static MeshData GenerateTriangle()
    {
        MeshData meshData = new MeshData();

        // Todo: Add the vertices that makes up triangle
        meshData.vertices = new Vector3[]
        {
        };

        // Todo: Add the sequence of vertices to form the triangle
        meshData.triangles = new int[] 
        { 
        };

        return meshData;
    }
}
