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

    protected Quest(string id, string name, Task rootTask, ProgressState state = ProgressState.NOT_STARTED)
    {
        tasks = new List<Task>(); //create an empty collection container of tasks
        tasks.Add(rootTask);
        questID = id;
        questName = name;
        questState = state;
        BuildQuest();
    }

    public virtual void BuildQuest() { }

}
