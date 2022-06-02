using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pop : MonoBehaviour
{
    public float sinGen = 0;
    float maxGen = Mathf.PI;
    public float sinSpeed = 0;
    public float sinSize = 0;
    Camera cam;
    float ort;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        transform.localScale = Vector3.zero;
        ort = cam.orthographicSize;
        transform.position = new Vector3(UnityEngine.Random.Range(cam.transform.position.x - ort * 1.8f, cam.transform.position.x + ort * 1.8f),
            UnityEngine.Random.Range(cam.transform.position.y - ort, cam.transform.position.y + ort),
            3);
        gameObject.tag = "star";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        sinGen++;
        if (sinGen * sinSpeed <= maxGen)
        {
            transform.localScale = new Vector3(Mathf.Sin(sinGen * sinSpeed) * sinSize / 100, Mathf.Sin(sinGen * sinSpeed) * sinSize / 100);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
