using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit_collide : MonoBehaviour
{

    //public Animator animator;
    public bool toTrigger = true;
    public GameObject GameWon;
    public Help help;


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
            PlayerMove.hasChest = false;
            GameWon.SetActive(true);
            help.help3.SetActive(false);
            help.off = true;
            

        }
    }
}
