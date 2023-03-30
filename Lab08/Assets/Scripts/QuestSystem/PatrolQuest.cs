using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PatrolQuest : Quest
{
    public GameObject target;
    public List<Transform> patrolPoints;
    public Transform startLocation;


    public PatrolQuest(string id, string name, Task rootTask, GameObject questTarget, Transform location) : base(id, name, rootTask)
    {
        target = questTarget;
        startLocation = location;
        BuildQuest();
    }

    public override void BuildQuest()
    {
        int count = 0;
        foreach (var location in patrolPoints)
        {
            tasks.Add(new LocationTask(count.ToString(), "Location " + count.ToString(), tasks[count], null, target, startLocation));
            count++;
        }

        for (var i = 0; i < tasks.Count; i++)
        {
            tasks[i].nextTask = i < tasks.Count - 1 ? tasks[i + 1] : null;
        }

    }
}
