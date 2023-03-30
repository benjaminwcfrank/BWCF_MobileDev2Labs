using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestMgr : MonoBehaviour
{
    public GameObject playerRef;
    public Transform startLocation;
    public List<Quest> quests;
    public Quest currentQuest;

    // Start is called before the first frame update
    void Start()
    {
        currentQuest = new PatrolQuest("Patrol1", "Patrol the Map", new LocationTask("task1", "Start Location", null, null, playerRef, startLocation), playerRef, startLocation);

        quests.Add(currentQuest);
    }
}
