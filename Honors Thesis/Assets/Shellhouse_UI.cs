using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shellhouse_UI : MonoBehaviour
{
	public SpriteRenderer spriteRenderer;    

	void OnMouseEnter()
     {
         spriteRenderer.color = Color.yellow;
     }
     void OnMouseExit()
     {
         spriteRenderer.color = Color.white;
     }
}
