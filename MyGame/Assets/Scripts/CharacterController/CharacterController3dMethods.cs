using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Entity;

namespace CharacterController
{
    public partial class CharacterController3d : EntityBase
    {
        // Movement
        protected void Move(float moveDirection = 1f)
        {
            if (moveDirection == 0f)
                return;
            velocity = transform.forward * moveSpeed * moveDirection;
            rigidbody.velocity = (rigidbody.velocity - new Vector3(rigidbody.velocity.x, 0, rigidbody.velocity.z)) + velocity;
        }

        protected void Rotate()
        {
            if (rotationDirection == 0f)
                return;
            transform.Rotate(new Vector3(0, rotationDirection, 0) * Time.deltaTime * rotationSpeed);
        }

        protected void Gravity()
        {
            if (gravity == 0f)
                return;
            rigidbody.AddForce(new Vector3(0, gravity, 0));
        }

        protected void ChangeRotationDirection(float direction = 0)
        {
            try
            {
                RotationDirection = direction;
            }
            catch (ArgumentException e)
            {
                Debug.Log(e.GetType().Name + " " + e.Message);
            }
        }
    }
}