using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSoldierAnimController : MonoBehaviour
{
    private Animator animator;
    private int animIndex;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator == null)
            return;

        

        if (Input.GetKeyDown(KeyCode.O))
        {
            animator.SetInteger("demoAnimState", 0);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            animator.SetInteger("demoAnimState", 1);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            animator.SetInteger("demoAnimState", 2);
        }
    }
}
