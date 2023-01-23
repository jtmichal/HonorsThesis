using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellHouse : MonoBehaviour
{
    public Overlay menu;

    Rigidbody2D rigidbody2D;
    SpriteRenderer spriteRenderer;
    
    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        menu.Awake();
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
        menu.OnMouseDown();
     }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
