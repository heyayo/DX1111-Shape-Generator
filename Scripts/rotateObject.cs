using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObject : MonoBehaviour
{
	float sinGen = 0;
	public bool rotate = false;
	float rotateSpeed = 1;
	public float rotateRate = 1;
	public bool rotateSin = false;
	public float sinLength = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		if (rotate)
		{
			if (rotateSin)
			{
				sinGen++;
				rotateSpeed = Mathf.Sin(sinGen * rotateRate/10) * sinLength;
			}
			transform.Rotate(0,0,rotateSpeed * rotateRate/10);
		}
        
    }
}
