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
        animator = GetComponent<Animator>();
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("In Trigger");
        Debug.Log(collider.tag);
        Debug.Log(collider.gameObject.name);
        if (collider.tag == "Player" && toTrigger == true && PlayerMove.hasKey == true)
        {
            Debug.Log("SUCCESS");
            PlayerMove.hasChest = true;
            animator.enabled = true;
            Exit.SetActive(true);

            toTrigger = false;
            
        }
    }
}
