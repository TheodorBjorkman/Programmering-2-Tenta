using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharacterController;

public class PlayerController : CharacterController3d
{
    private float moveDirection = 0;
    // Start is called before the first frame update
    // void Start()
    // {
    //     StartController();
    // }

    // Update is called once per frame
    void Update()
    {
        moveDirection = Input.GetAxisRaw("Vertical");
        ChangeRotationDirection(Input.GetAxisRaw("Horizontal"));        // Gets horizontal directional input: w/left arrow = -1, n/a = 0, d/right arrow = 1
        if (Input.GetKeyDown(KeyCode.LeftShift)) this.MoveSpeed += 20f;
        if (Input.GetKeyUp(KeyCode.LeftShift)) this.MoveSpeed -= 10f;
        if (Input.GetKeyDown(KeyCode.R)) this.RotationSpeed += 20f;
        if (Input.GetKeyDown(KeyCode.E)) this.RotationSpeed -= 20f;
    }

    // Update is called at fixed intervals
    void FixedUpdate()
    {
        Rotate();
        Gravity();
        Move(moveDirection);
    }
}
