using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers
{
    public class PlayerController : CharacterController3d
    {
        private float moveDirection = 0;
        // Awake is called upon load.
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
        // Checks for input each frame. MoveSpeed is basically fixed with this, better way might be to just set a bool for sprint true or false if versatility is desired
        void Update()
        {
            moveDirection = Input.GetAxisRaw("Vertical");
            ChangeRotationDirection(Input.GetAxisRaw("Horizontal"));        // Gets horizontal directional input: w/left arrow = -1, no input = 0, d/right arrow = 1
            if (Input.GetKey(KeyCode.LeftShift))
                MoveSpeed = 8f;
            else
                MoveSpeed = 1f;
        }

        // Update is called at fixed intervals
        void FixedUpdate()
        {
            Rotate();
            ApplyGravity();
            Move(moveDirection);
        }
    }
}