using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Entity;

namespace Controllers
{
    public partial class CharacterController3d : EntityBase
    {
        /// <summary>
        /// Contains the methods that decide how things happen.
        /// </summary>
        protected void Move(float moveDirection = 1f)
        {
            // Checks if there is no move direction in which case it skips the rest of the method to save performance
            if (moveDirection == 0f)
                return;
            velocity = transform.forward * moveSpeed * moveDirection;
            Rigidbody.velocity = (Rigidbody.velocity - new Vector3(Rigidbody.velocity.x, 0, Rigidbody.velocity.z)) + velocity;
        }

        protected void Rotate()
        {
            // Checks if there is no rotation direction in which case it skips the rest of the method to save performance
            if (rotationDirection == 0f)
                return;
            transform.Rotate(new Vector3(0, rotationDirection, 0) * Time.deltaTime * rotationSpeed);
        }

        protected void ApplyGravity()
        {
            // Checks if there is no gravity in which case it skips the rest of the method to save performance
            if (gravity == 0f)
                return;
            Rigidbody.AddForce(new Vector3(0, gravity, 0));
        }

        protected void ChangeRotationDirection(float direction = 0)
        {
            // Tries to change rotation direction, will catch the thrown error in case of invalid input
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