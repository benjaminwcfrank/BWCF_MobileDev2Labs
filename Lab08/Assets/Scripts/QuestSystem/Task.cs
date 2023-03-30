using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Task
{
    [Header("Task Properties")]
    public string taskID;
    ProgressState state;
    public Task nextTask;
    public Task prevTask;
    public ProgressStateTexts texts;
    public string nameOfTask;

    public Task(string id, string name, Task prev, Task next, ProgressState startState = ProgressState.NOT_STARTED)
    {
        nameOfTask = name;
        taskID = id;
        prevTask = prev;
        nextTask = next;

        if(prevTask != null && prevTask.state != ProgressState.COMPLETED)
        {
            state = ProgressState.INVALID; //cannot start this task until prev task is completed. Assumes prev task exsists.
        }

    }

    public virtual bool Condition() {return false; }
}
