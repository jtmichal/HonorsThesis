using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour
{
    public GameObject help1;
    public GameObject help2;
    public GameObject help3;
    public bool off = false;
    float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        off = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (off == false)
        {
            if ((timer > 10) && !PlayerMove.hasKey)
            {
                help1.SetActive(true);
            }
            if ((timer > 20) && !PlayerMove.hasChest)
            {
                help2.SetActive(true);
            }
            if ((timer > 30) && PlayerMove.hasChest)
            {
                help3.SetActive(true);
            }
        }
        
    }
}
