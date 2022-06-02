using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfOrbit : MonoBehaviour
{
    public bool rotate = false;
    public float rotationRate = 0;
    public bool lockOrbit = false;
    public Transform target = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (lockOrbit)
        {
            transform.right = target.position - transform.position;
            transform.Rotate(0, 0, 90);
        }
    }
    private void FixedUpdate()
    {
        if (rotate)
        {
            transform.Rotate(0, 0, rotationRate);
        }
    }
}
