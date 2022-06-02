using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundStarGenerator : MonoBehaviour
{
    public GameObject star;
    public int starCount;
    public float sinSpeed;
    public float sinSize;
    int currentStarCount = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (currentStarCount < starCount)
        {
            GameObject newstar = Instantiate(star);
            pop popp = newstar.AddComponent<pop>();
            popp.sinSpeed = sinSpeed;
            popp.sinSize = sinSize;
            popp.sinGen = 0;
        }
        currentStarCount = GameObject.FindGameObjectsWithTag("star").Length;
    }
}
