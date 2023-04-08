using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PatrolQuest : Quest
{
    [Header("PatrolQuest Patrol Points")]
    public GameObject target;
    public List<Transform> patrolPoints;
    public Transform startLocation;


    public PatrolQuest(string id, string name, LocationTask rootTask, List<Transform> patrolPointsPassed, ProgressState startState = ProgressState.NOT_STARTED) : base(id, name, rootTask, startState)
    {
        
        target = rootTask.target;
        startLocation = rootTask.location;
        patrolPoints = patrolPointsPassed;

        Debug.Log(patrolPoints.Count);
    }

    public override void BuildQuest()
    {


        //add as many location tasks as there are transforms in PatrolPoints
        for (int i = 0; i < patrolPoints.Count; i++)
        {
            tasks.Add(new LocationTask("LocTask+ " + i.ToString(), "Loc+ " + i.ToString(), (i > 0) ? tasks[i - 1] : null, null, target, patrolPoints[i]));
        }


        //Link each task's nextTask together
        for (int i = 0; i < tasks.Count; i++)
        {
            tasks[i].nextTask = (i < tasks.Count - 1) ? tasks[i + 1] : null;
        }

    }
}
