using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Controllers;

public class Spawner : MonoBehaviour
{
    /// <summary>
    /// Just recreates the player when the respawn key is pressed, could assign a variable for it if settings to change controls are to be added.
    /// Also spawns player on start.
    /// </summary>
    private void Awake()
    {
        GameObject newPlayer = new GameObject("Player");
        newPlayer.AddComponent<PlayerController>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Destroy(GameObject.Find("Player"));
            GameObject newPlayer = new GameObject("Player");
            newPlayer.AddComponent<PlayerController>();
        }
    }
}
