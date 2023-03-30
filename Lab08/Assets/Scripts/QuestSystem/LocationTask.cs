using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LocationTask : Task
{
    public GameObject target;
    public Transform location;

    public LocationTask(string id, string name, Task prev, Task next, GameObject taskTarget, Transform taskLocation, ProgressState startState = ProgressState.NOT_STARTED)
        : base(id, name, prev, next, startState)
    {
        target = taskTarget;
        location = taskLocation;
    }
    
    public override bool Condition()
    {
        return Vector3.Distance(target.transform.position, location.position) < 0.5f;
    }
}
