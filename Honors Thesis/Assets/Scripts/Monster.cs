using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]

public class Monster : MonoBehaviour
{
    [SerializeField] Sprite deadSprite;
    [SerializeField] ParticleSystem particleSystem;
    private bool hasDied;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (ShouldDieFromCollision(collision))
        {
            StartCoroutine(Die());
        }
    }

    bool ShouldDieFromCollision(Collision2D collision)
    {
        if (hasDied)
        {
            return false;
        }
        
        Finn finn = collision.gameObject.GetComponent<Finn>();
        if (finn != null)
        {
            return true;
        }

        if (collision.contacts[0].normal.y < -0.5)
        {
            return true;
        }

        return false;
    }

    IEnumerator Die()
    {
        hasDied = true;
        GetComponent<SpriteRenderer>().sprite = deadSprite;
        particleSystem.Play();
        yield return new WaitForSeconds(1);
        
        gameObject.SetActive(false);
    }
}
