using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest
{
    public string questName;
    public string questID;
    public ProgressState questState;
    public List<Task> tasks;
    public Task currentTask;

    protected Quest(string id, string name, Task rootTask, ProgressState state = ProgressState.NOT_STARTED)
    {

        questID = id;
        questName = name;
        questState = state;
        tasks = new List<Task> { rootTask }; //create an list container of tasks containing only rootTask
        currentTask = rootTask;
        //BuildQuest();
    }

    public virtual void BuildQuest() { }

}
