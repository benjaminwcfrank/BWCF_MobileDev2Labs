using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardHit : MonoBehaviour
{
    public int damageToDeal = 5;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player")
                return;

        collision.gameObject.GetComponent<HealthbarController>().TakeDamage(damageToDeal);
    }

}
