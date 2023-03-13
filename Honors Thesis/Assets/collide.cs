using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour
{

    public Animator animator;
    public bool toTrigger = true;
    public GameObject Exit;
    public GameObject Chest;

    void Start()
    {
        animator = Chest.GetComponent<Animator>();
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
            Exit.SetActive(true);

            toTrigger = false;
            
        }
    }
}
