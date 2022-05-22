using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRing : MonoBehaviour
{
    public GameObject ring;
    public int ringCount = 1;
    public float ringXOffset = 1;
    public float ringYOffset = 1;
    public float ringOrbit = 30;
    public float xRingOrbit = 1;
    public float yRingOrbit = 1;
    public float xRingOrbitRate = 1f;
    public float yRingOrbitRate = 1;
    public float ringOrbitRate = 1;
    // Start is called before the first frame update
    void Start()
    {
        GameObject parent = gameObject;
        for (int i = 0; i < ringCount; i++)
        {
            GameObject newring = Instantiate(ring, transform);
            sinScriptOffset ringScript = newring.AddComponent<sinScriptOffset>();
            newring.transform.Rotate(0, 0, UnityEngine.Random.Range(0,90));
            ringScript.sinOrbitOffsetX = i * ringXOffset;
            ringScript.sinOrbitOffsetY = i * ringYOffset;
            ringScript.sinOnlyOrbit = true;
            ringScript.xSinOrbit = xRingOrbit;
            ringScript.ySinOrbit = yRingOrbit;
            ringScript.sinUniOrbit = ringOrbit;
            ringScript.xSinOrbitRate = xRingOrbitRate;
            ringScript.ySinOrbitRate = yRingOrbitRate;
            ringScript.sinUniOrbitRate = ringOrbitRate;
        }
    }
}
