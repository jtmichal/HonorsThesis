using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit_collide : MonoBehaviour
{

    //public Animator animator;
    public bool toTrigger = true;
    public GameObject GameWon;


    void Start()
    {
        
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("In Trigger");
        Debug.Log("hasKey value is..." + PlayerMove.hasKey);
        if (collider.gameObject.tag == "Player" && toTrigger == true && PlayerMove.hasChest == true)
        {
            
            toTrigger = false;
            PlayerMove.hasKey = false;
            GameWon.SetActive(true);

        }
    }
}