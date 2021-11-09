using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : CharacterController2d
{
    // Start is called before the first frame update
    // void Start()
    // {
    //     StartController();
    // }

    // Update is called once per frame
    void Update()
    {
        ChangeRotationDirection();
    }

    // Update is called at fixed intervals
    // void FixedUpdate()
    // {

    // }

    void ChangeRotationDirection()
    {
        try
        {
            rotationDirection = Input.GetAxisRaw("Horizontal");     // Gets horizontal directional input: w/left arrow = -1, n/a = 0, d/right arrow = 1
        }
        catch (ArgumentException e)
        {
            Debug.Log("{0}: {1}", e.GetType().Name, e.Message);
        }
    }
}
