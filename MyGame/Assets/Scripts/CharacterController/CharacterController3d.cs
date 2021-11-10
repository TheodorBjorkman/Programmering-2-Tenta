using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CharacterController 
{
    public partial class CharacterController3d : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            StartController();
        }

        protected void StartController()
        {
            rigidbody = GetComponent<Rigidbody>();
            transform = GetComponent<Transform>();

            if (TouchWallEvent == null)
                TouchWallEvent = new UnityEvent();
        }

        // Update is called at fixed intervals
        void FixedUpdate()
        {
            Move();
            Rotate();
            Gravity();
        }
    }
}