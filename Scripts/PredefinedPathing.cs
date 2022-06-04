using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredefinedPathing : MonoBehaviour
{
    // Start is called before the first frame update
    FollowObject pather;
    public TMPro.TextMeshProUGUI planetInfo;
    int waitTime = 10;
    void Start()
    {
        pather = this.gameObject.GetComponent<FollowObject>();
        StartCoroutine(path());
        planetInfo.fontSize = 80;
    }
    IEnumerator path()
    {
        while (true)
        {
            planetInfo.text = "Sun";
            pather.follow = GameObject.Find("Sun").transform;
            yield return new WaitForSeconds(waitTime);
            planetInfo.text = "Earth";
            pather.follow = GameObject.Find("Earth").transform;
            yield return new WaitForSeconds(waitTime);
            planetInfo.text = "Mercury";
            pather.follow = GameObject.Find("Mercury").transform;
            yield return new WaitForSeconds(waitTime);
            planetInfo.text = "Mars";
            pather.follow = GameObject.Find("Mars").transform;
            yield return new WaitForSeconds(waitTime);
            planetInfo.text = "Mars' Moon Deimos";
            pather.follow = GameObject.Find("Deimos").transform;
            yield return new WaitForSeconds(waitTime);
            planetInfo.text = "Venus";
            pather.follow = GameObject.Find("Venus").transform;
            yield return new WaitForSeconds(waitTime);
            planetInfo.text = "Jupiter";
            pather.follow = GameObject.Find("Jupiter").transform;
            yield return new WaitForSeconds(waitTime);
            planetInfo.text = "Saturn";
            pather.follow = GameObject.Find("Saturn").transform;
            yield return new WaitForSeconds(waitTime);
            planetInfo.text = "Ur|anus";
            pather.follow = GameObject.Find("Uranus").transform;
            yield return new WaitForSeconds(waitTime);
            planetInfo.text = "Neptune";
            pather.follow = GameObject.Find("Neptune").transform;
            yield return new WaitForSeconds(waitTime);
            planetInfo.text = "A Satellite Orbiting Earth";
            pather.follow = GameObject.Find("Satellite Panel").transform;
            yield return new WaitForSeconds(waitTime);
            planetInfo.text = "Jupiter's Moon Ganymede";
            pather.follow = GameObject.Find("Ganymede").transform;
            yield return new WaitForSeconds(waitTime);
            planetInfo.text = "Jupiter's Moon IO";
            pather.follow = GameObject.Find("IO").transform;
            yield return new WaitForSeconds(waitTime);
            planetInfo.text = "Earth's Moon";
            pather.follow = GameObject.Find("Moon").transform;
            yield return new WaitForSeconds(waitTime);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
