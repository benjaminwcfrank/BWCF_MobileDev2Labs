using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlane : MonoBehaviour
{
    public Vector3 respawnPos;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<CharacterController>().enabled = false;
            other.gameObject.transform.position = respawnPos;
            other.GetComponent<CharacterController>().enabled = true;
        }
    }
}
