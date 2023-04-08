using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestMgr : MonoBehaviour
{
    public GameObject playerRef;
    public Transform startLocation;
    public List<Quest> quests;
    public Quest currentQuest;

    // Start is called before the first frame update
    void Start()
    {
        currentQuest = new PatrolQuest("Patrol1", "Patrol the Map", new LocationTask("task1", "Start Location", null, null, playerRef, startLocation));

        quests.Add(currentQuest);
        currentQuest.questState = ProgressState.IN_PROGRESS;

    }


    private void Update()
    {
        if (currentQuest.questState != ProgressState.IN_PROGRESS) return;

        if (currentQuest.currentTask.Condition())
        {
            Debug.Log(currentQuest.currentTask.nameOfTask + " is completed");
            
            
            currentQuest.currentTask.state = ProgressState.COMPLETED;


            if (currentQuest.currentTask.nextTask != null)
            {
                Debug.Log("Moving onto next task");
                currentQuest.currentTask = currentQuest.currentTask.nextTask;
                currentQuest.currentTask.state = ProgressState.IN_PROGRESS;
            }
            else
            {
                Debug.Log(currentQuest.questName + " is completed");
                currentQuest.questState = ProgressState.COMPLETED;
            }
        }
    }
}
