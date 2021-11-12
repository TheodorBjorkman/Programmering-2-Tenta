using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharacterController;

public class PlayerController : CharacterController3d
{
    // Start is called before the first frame update
    // void Start()
    // {
    //     StartController();
    // }

    // Update is called once per frame
    void Update()
    {
        ChangeRotationDirection(Input.GetAxisRaw("Horizontal"));        // Gets horizontal directional input: w/left arrow = -1, n/a = 0, d/right arrow = 1
        if (Input.GetKeyDown(KeyCode.M)) ChangeMoveSpeed(20f);
        if (Input.GetKeyDown(KeyCode.N)) ChangeMoveSpeed(5f);
        if (Input.GetKeyDown(KeyCode.B)) ChangeMaxSpeed(20f);
        if (Input.GetKeyDown(KeyCode.R)) ChangeRotationSpeed(180f);
    }

    // Update is called at fixed intervals
    // void FixedUpdate()
    // {

    // }
}
