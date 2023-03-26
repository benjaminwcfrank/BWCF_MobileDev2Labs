using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Target
{
    public Transform transform;
    public Vector3 offset;
    public bool useXOffset;
    public bool useYOffset;
    public bool useZOffset;
}

[ExecuteInEditMode] //<- USE WITH CAUTION. AKIN TO CONSTRUCTOR SCRIPT IN UE4
public class Follow : MonoBehaviour
{
    public Target target;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            (target.useXOffset) ? target.transform.position.x + target.offset.x : transform.position.x,
            (target.useYOffset) ? target.transform.position.y + target.offset.y : transform.position.y,
            (target.useZOffset) ? target.transform.position.z + target.offset.z : transform.position.z
            );
    }
}
