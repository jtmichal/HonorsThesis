using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinnMain : MonoBehaviour
{
    
    Vector2 startPosition;
    Rigidbody2D rigidbody2D;
    SpriteRenderer spriteRenderer;
    
    void Awake(){
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        startPosition = rigidbody2D.position;
        rigidbody2D.isKinematic = true;
    }

    void OnMouseDown(){
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 desiredPosition = mousePosition;

        rigidbody2D.position = desiredPosition;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
