using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellHouse : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    SpriteRenderer spriteRenderer;
    public bool isVisible = false;
    public GameObject test;
    
    void Awake()
    {
        test = GameObject.Find("Popup");
        test.SetActive(false);
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

     void OnMouseEnter()
     {
         spriteRenderer.color = Color.yellow;
     }
     void OnMouseExit()
     {
         spriteRenderer.color = Color.white;
     }

     void OnMouseDown(){
        test.SetActive(true);
     }


    
    // Update is called once per frame
    void Update()
    {
        
    }
}
