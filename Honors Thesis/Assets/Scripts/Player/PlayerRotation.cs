using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float speed;
    public float rotationOffset;
    public SpriteRenderer test;
    // Start is called before the first frame update
    void Start()
    {
        test = GetComponent<SpriteRenderer>();
        GetComponent<Rigidbody2D>().isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 0;
        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);

        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        //Debug.Log(angle);
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + rotationOffset));

        if (angle<-90 || angle>90){
            test.flipY = true;
        }
        
        else{
            test.flipY = false;
        }
        //Vector3 targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //targetPos.z = 0;
        //transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

    }
}
