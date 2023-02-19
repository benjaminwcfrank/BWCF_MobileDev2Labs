
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class HealthbarController : MonoBehaviour
{
    [Header("Health Properties")]
    public int healthValue;

    [Header("Display Properties")]
    public Slider healthBarRef;


    // Start is called before the first frame update
    void Start()
    {
        //healthBarRef = GetComponentInChildren<Slider>();
        ResetHealth();
    }

    public void ResetHealth()
    {
        healthBarRef.value = 100;
        UpdateHealthValue();
    }

    public void TakeDamage(int damageReceived)
    {
        healthBarRef.value -= damageReceived;

        if (healthBarRef.value <= 0)
            healthBarRef.value = 0;
        UpdateHealthValue();
    }

    public void HealDamage(int healthAdded)
    {
        healthBarRef.value += healthAdded;

        if (healthBarRef.value >= 100)
            healthBarRef.value = 100;
        UpdateHealthValue();
    }

    private void UpdateHealthValue()
    {
        healthValue = (int)healthBarRef.value;
    }
}
