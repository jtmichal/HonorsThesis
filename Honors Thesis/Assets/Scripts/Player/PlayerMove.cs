using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Movespeed towards mouse
    public float speed;       // Speed of character moving towards clicking
    private Vector3 target;         // Right-clicked target location
    private Vector3 origin;
    float timer = 0.0f;
    public bool idle = false;
    public static bool hasKey = false;
    public GameObject Key;
    private Rigidbody2D player;

    private bool isFacingRight = true;
    private bool isJumping = false;
    public float jumpForce;
    public float downForce;
    public float moveInput;


    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
        origin = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.5f));
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // If we right click, gather data for a new point to travel towards.
        //idle = true;
        //if(Input.GetMouseButtonDown(1))     // 0 = left mouse button, 1 = right mouse button
        {
            moveInput = Input.GetAxis("Horizontal");
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                isJumping = true;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow)){
                player.AddForce(new Vector2(0f, downForce));
                //transform.position += Vector3.down * downForce * speed * Time.deltaTime;
            }
            idle = false;
            //Debug.Log("Timer reset.");
            timer = 0;
            //target = Camera.main.ScreenToWorldPoint(Input.mousePosition);   // If any camera changes happen and movement breaks, look at this
            //target.z = transform.position.z;    // 2D, z-axis needs to be the same
        }
        //else{
        //    if(idle){
        //        timer += Time.deltaTime;
        //    }
        //    if (timer >= 10){
        //        Debug.Log("Idle.");
        //        target = origin;
        //        target.z = transform.position.z;
        //    }
        //}

        // Move towards the clicked location
        //transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        player.velocity = new Vector2(moveInput * speed, player.velocity.y);
        if (isFacingRight == false && moveInput > 0)
        {
            FlipPlayer();
        }
        else if (isFacingRight == true && moveInput < 0)
        {
            FlipPlayer();
        }

        if (isJumping)
        {
            player.AddForce(new Vector2(0f, jumpForce));
            isJumping = false;
        }
    }

    private void FlipPlayer()
    {
        isFacingRight = !isFacingRight;
        Vector3 playerScale = transform.localScale;
        playerScale.x *= -1;

        transform.localScale = playerScale;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        name = collision.gameObject.name;
        if (name == "Key")
        {
            Debug.Log("YERRRRRR");
            hasKey = true;
            Key.SetActive(false);
        }
        else if (name == "Key")
        {
            Debug.Log("Something something");
        }
        
        //transform.position = origin;
        //Debug.Log("TRIGGER!");
        // This was here to test when the character model bumps into stuff
    }
}
