using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PregameUI : MonoBehaviour
{
    public GameObject UI;

    // Update is called once per frame
    void Update()
    {
        if (UI.activeSelf == true){
            Pause();
        }
            
    }

    public void Pause(){
        Time.timeScale = 0f;
    }

    public void UnPause(){
        Time.timeScale = 1f;
    }
}
