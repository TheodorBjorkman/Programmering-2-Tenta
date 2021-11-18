using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharacterController;

public class PlayerController : CharacterController3d
{
    private float moveDirection = 0;
    // Start is called before the first frame update
    void Awake()
    {
        StartController();
        MeshFilter meshF = gameObject.AddComponent<MeshFilter>();
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        MeshFilter cubeMeshF = cube.GetComponent(typeof(MeshFilter)) as MeshFilter;
        meshF.mesh = cubeMeshF.mesh;
        Destroy(cube);
        gameObject.AddComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = Input.GetAxisRaw("Vertical");
        ChangeRotationDirection(Input.GetAxisRaw("Horizontal"));        // Gets horizontal directional input: w/left arrow = -1, n/a = 0, d/right arrow = 1
        if (Input.GetKeyDown(KeyCode.LeftShift))
            this.MoveSpeed += 2f;
        if (Input.GetKeyUp(KeyCode.LeftShift))
            this.MoveSpeed -= 1f;
        if (Input.GetKeyDown(KeyCode.R))
            this.RotationSpeed += 20f;
        if (Input.GetKeyDown(KeyCode.E))
            this.RotationSpeed -= 20f;
        if (Input.GetKeyDown(KeyCode.Q))
            this.Health -= 50;
        if (Input.GetKeyDown(KeyCode.L))
            Destroy(gameObject);
    }

    // Update is called at fixed intervals
    void FixedUpdate()
    {
        Rotate();
        Gravity();
        Move(moveDirection);
    }
}
