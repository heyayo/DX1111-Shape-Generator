using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredefinedPathing : MonoBehaviour
{
    // Start is called before the first frame update
    FollowObject pather;
    TMPro.TextMeshPro planetInfo;
    void Start()
    {
        pather = this.gameObject.GetComponent<FollowObject>();
        StartCoroutine(path());
        planetInfo = Instantiate(planetInfo);
        planetInfo.fontSize = 50;
        planetInfo.text = "TEST";
    }
    IEnumerator path()
    {
        pather.follow = GameObject.Find("Sun").transform;
        yield return new WaitForSeconds(5);
        pather.follow = GameObject.Find("Earth").transform;
        yield return new WaitForSeconds(5);
        pather.follow = GameObject.Find("Mercury").transform;
        yield return new WaitForSeconds(5);
        pather.follow = GameObject.Find("Mars").transform;
        yield return new WaitForSeconds(5);
        pather.follow = GameObject.Find("Deimos").transform;
        yield return new WaitForSeconds(5);
        pather.follow = GameObject.Find("Venus").transform;
        yield return new WaitForSeconds(5);
        pather.follow = GameObject.Find("Jupiter").transform;
        yield return new WaitForSeconds(5);
        pather.follow = GameObject.Find("Saturn").transform;
        yield return new WaitForSeconds(5);
        pather.follow = GameObject.Find("Uranus").transform;
        yield return new WaitForSeconds(5);
        pather.follow = GameObject.Find("Neptune").transform;
        yield return new WaitForSeconds(5);
        pather.follow = GameObject.Find("Satellite Panel").transform;
        yield return new WaitForSeconds(5);
        pather.follow = GameObject.Find("Ganymede").transform;
        yield return new WaitForSeconds(5);
        pather.follow = GameObject.Find("IO").transform;
        yield return new WaitForSeconds(5);
        pather.follow = GameObject.Find("Moon").transform;
        yield return new WaitForSeconds(5);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
