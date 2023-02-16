using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public Transform GMtoFollow;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = GMtoFollow.position + offset;
        transform.eulerAngles = new Vector3(90, GMtoFollow.eulerAngles.y, 0);
    }
}
