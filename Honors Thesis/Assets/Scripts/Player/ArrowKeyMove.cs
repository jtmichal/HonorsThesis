using UnityEngine;
 using System.Collections;
 
 public class ArrowKeyMove : MonoBehaviour
 {
     public float speed = 8f;
     public float jump_force = 8f;
 
     void Update ()
     {
         if (Input.GetKey(KeyCode.LeftArrow))
         {
             transform.position += Vector3.left * speed * Time.deltaTime;
         }
         if (Input.GetKey(KeyCode.RightArrow))
         {
             transform.position += Vector3.right * speed * Time.deltaTime;
         }
         if (Input.GetKey(KeyCode.UpArrow))
         {
             //GetComponent<Rigidbody2D>().gravityScale = 10f;
             transform.position += Vector3.up * jump_force * speed * Time.deltaTime;
         }
         if (Input.GetKey(KeyCode.DownArrow))
         {
             transform.position += Vector3.down * speed * Time.deltaTime;
         }
     }
 }