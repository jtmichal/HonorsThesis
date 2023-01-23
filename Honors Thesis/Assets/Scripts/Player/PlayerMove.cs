using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Movespeed towards mouse
    public float speed = 75f;       // Speed of character moving towards clicking
    private Vector3 target;         // Right-clicked target location
    private Vector3 origin;
    float timer = 0.0f;
    public bool idle = false;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
        origin = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.5f));
    }

    // Update is called once per frame
    void Update()
    {
        // If we right click, gather data for a new point to travel towards.
        idle = true;
        if(Input.GetMouseButtonDown(1))     // 0 = left mouse button, 1 = right mouse button
        {
            idle = false;
            Debug.Log("Timer reset.");
            timer = 0;
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);   // If any camera changes happen and movement breaks, look at this
            target.z = transform.position.z;    // 2D, z-axis needs to be the same
        }
        else{
            if(idle){
                timer += Time.deltaTime;
            }
            if (timer >= 10){
                Debug.Log("Idle.");
                target = origin;
                target.z = transform.position.z;
            }
        }

        // Move towards the clicked location
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.position = origin;
        Debug.Log("TRIGGER!");
        // This was here to test when the character model bumps into stuff
    }
}
