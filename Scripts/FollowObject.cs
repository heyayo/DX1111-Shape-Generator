using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform follow = null;
    Transform oldFollow;
    float interp = 0;
    float scaleinterp = 0;
    public float camSizeMultiplier = 1;
    Camera mainCamera;
    MeshObject meshObject = null;

    public float interpSpeed = 1;
    public float scaleInterpSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        oldFollow = follow;
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (follow != oldFollow)
        {
            interp = 0;
            scaleinterp = 0;
            oldFollow = follow;
            meshObject = follow.gameObject.GetComponent<MeshObject>();
        }
        if (follow)
        {
            transform.localPosition = new Vector3(
            Mathf.Lerp(transform.localPosition.x, follow.position.x, interp * interpSpeed),
            Mathf.Lerp(transform.localPosition.y, follow.position.y, interp * interpSpeed),
            -10
            );
            // transform.localScale = new Vector3(Mathf.Lerp(transform.localScale.x, follow.localScale.x, scaleinterp), Mathf.Lerp(transform.localScale.y, follow.localScale.y, scaleinterp)
            if (meshObject)
            {
                if (mainCamera.orthographicSize < meshObject.InitialxScale * 9.9 || mainCamera.orthographicSize > meshObject.InitialxScale * 1.1)
                {
                    mainCamera.orthographicSize = Mathf.Lerp(
                    mainCamera.orthographicSize,
                    meshObject.InitialxScale * 10,
                    scaleinterp * scaleInterpSpeed)
                    * camSizeMultiplier;
                }
            }
        }
    }
    private void FixedUpdate()
    {
        interp += 0.1f;
        scaleinterp += 0.1f;
    }
}
