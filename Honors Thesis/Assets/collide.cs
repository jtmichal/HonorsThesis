using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour
{

    public Animator animator;
    public bool toTrigger = true;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("In Trigger");
        Debug.Log("hasKey value is..." + PlayerMove.hasKey);
        if (collider.gameObject.tag == "Player" && toTrigger == true && PlayerMove.hasKey == true)
        {
            animator.enabled = !animator.enabled;
            toTrigger = false;
            
        }
    }
}
