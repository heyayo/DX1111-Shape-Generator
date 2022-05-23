using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundStarGenerator : MonoBehaviour
{
    public GameObject star;
    public int starCount;
    public float starScale;
    // Start is called before the first frame update
    void Start()
    {
        float randomScale;
        for (int i = 0; i < starCount; i++)
        {
            GameObject newStar = star;
            MeshObject starMesh = newStar.GetComponent<MeshObject>();
            randomScale = UnityEngine.Random.value * starScale;
            starMesh.InitialxScale = randomScale;
            starMesh.InitialyScale = randomScale;
            starMesh.Initialrotation = UnityEngine.Random.Range(180,270);
            rotateObject rotator = newStar.AddComponent<rotateObject>();
            rotator.rotate = true;
            rotator.rotateRate = UnityEngine.Random.value;
            Instantiate(newStar);
            newStar.transform.position = new Vector3(UnityEngine.Random.Range(-3000,3000), UnityEngine.Random.Range(-3000,3000), 3);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
