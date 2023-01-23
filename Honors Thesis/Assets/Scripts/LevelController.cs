using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] string nextLevelName;

    private Monster[] monsters;

    private void OnEnable()
    {
        monsters = FindObjectsOfType<Monster>();
    }
    // Update is called once per frame
    void Update()
    {
        if (MonstersAreAllDead())
        {
            GoToNextLevel();
        }
    }

    private void GoToNextLevel()
    {
        Debug.Log("Go to level " + nextLevelName);
        SceneManager.LoadScene(nextLevelName);
    }

    private bool MonstersAreAllDead()
    {
        foreach (var monster in monsters)
        {
            if (monster.gameObject.activeSelf)
            {
                return false;
            }
        }

        return true;
    }
}
