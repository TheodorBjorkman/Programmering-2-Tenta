using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : CharacterController2d
{
    // Start is called before the first frame update
    void Start()
    {
        StartController();
    }

    // Update is called once per frame
    void Update()
    {
        rotationDirection = Input.GetAxisRaw("Horizontal");
    }

    // Update is called at fixed intervals
    // void FixedUpdate()
    // {

    // }
}
