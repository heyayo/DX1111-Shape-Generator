using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinScript : MonoBehaviour
{
	float orbitSin = 0;
	float sinOrbitSin = 0;
	float scaleSin = 0;

	public bool orbit = false;
	public float xOrbit = 1;
	public float yOrbit = 1;
	public float uniOrbit = 1;
	public float xOrbitRate = 1;
	public float yOrbitRate = 1;
	public float uniOrbitRate = 1;

	public bool sinOnlyOrbit = false;
	public float xSinOrbit = 1;
	public float ySinOrbit = 1;
	public float sinUniOrbit = 1;
	public float xSinOrbitRate = 1;
	public float ySinOrbitRate = 1;
	public float sinUniOrbitRate = 1;

	public bool scaler = false;
	public float xScaler = 1;
	public float yScaler = 1;
	public float uniScaler = 1;
	public float scaleRate = 1;
		
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		if (orbit)
		{
			orbitSin++;
			transform.localPosition = new Vector3(Mathf.Cos(orbitSin * xOrbitRate*uniOrbitRate/10) * (xOrbit*uniOrbit), Mathf.Sin(orbitSin * yOrbitRate*uniOrbitRate/10) * (yOrbit*uniOrbit));
		}
		if (sinOnlyOrbit)
        {
			sinOrbitSin++;
			transform.localPosition = new Vector3(Mathf.Sin(sinOrbitSin * xSinOrbitRate * sinUniOrbitRate / 10) * xSinOrbit * sinUniOrbit, Mathf.Sin(sinOrbitSin * ySinOrbitRate * sinUniOrbitRate / 10) * ySinOrbit * sinUniOrbit);
        }
		if (scaler)
		{
			scaleSin++;
			transform.localScale += new Vector3(Mathf.Sin(scaleSin * scaleRate/10) * (xScaler*uniScaler/10),Mathf.Sin(scaleSin * scaleRate/10) * (yScaler*uniScaler/10));
		}
    }
}
