using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PatrolPointHandler : MonoBehaviour
{
    public Image icon;
    public Sprite checkmark;

    public void PatrolPointReached()
    {
        icon.sprite = checkmark;
    }

}
