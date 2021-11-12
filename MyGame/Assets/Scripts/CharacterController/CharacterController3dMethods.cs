using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CharacterController
{
    public partial class CharacterController3d : MonoBehaviour
    {
        // Movement
        protected void Move()
        {
            velocity = transform.forward * moveSpeed;
            rigidbody.velocity = (rigidbody.velocity - new Vector3(rigidbody.velocity.x, 0, rigidbody.velocity.z)) + velocity;
        }

        protected void Rotate()
        {
            transform.Rotate(new Vector3(0, rotationDirection, 0) * Time.deltaTime * rotationSpeed);
        }

        protected void Gravity()
        {
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

        protected void ChangeMoveSpeed(float newSpeed)
        {
            this.MoveSpeed = newSpeed;
        }

        protected void ChangeMaxSpeed(float newMax)
        {
            this.MaxSpeed = newMax;
        }

        protected void ChangeRotationSpeed(float newSpeed)
        {
            this.RotationSpeed = newSpeed;
        }
    }
}