using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum ProgressState
{
    ABANDONED,
    COMPLETED,
    FAILED,
    IN_PROGRESS,
    INVALID,
    NOT_STARTED,
}

[System.Serializable]
public struct ProgressStateTexts
{

    public string abandonedText;
    public string completedText;
    public string failedText;
    public string inProgressText;
    public string invalidText;
    public string notStartedText;
    public string shortDesc;
    public string longDesc;

}
