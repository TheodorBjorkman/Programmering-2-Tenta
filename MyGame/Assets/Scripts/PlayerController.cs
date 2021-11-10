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
        
    }

    // Update is called at fixed intervals
    // void FixedUpdate()
    // {

    // }
}
