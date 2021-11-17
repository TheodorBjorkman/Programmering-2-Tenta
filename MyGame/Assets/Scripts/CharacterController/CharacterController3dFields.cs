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
        // Fields of entity
        [SerializeField] private float rotationSpeed = 180f;     // Rotation speed of entity
        [SerializeField] private float maxRotationSpeed = 360f;     // Max rotation speed of entity
        [SerializeField] private float gravity = -15f;      // Force of gravity
        [SerializeField] private float moveSpeed = 1f;     // Movement speed of the entity
        [SerializeField] private float maxSpeed = 10f;      // Max movement speed of the entity
        [SerializeField] private int rotationDirection = 0;  //-1 is left, 1 is right
        private Vector3 velocity = Vector3.zero;        //Wanted velocity, calculated in the move method
        private Vector3 startPosition = new Vector3(0, 1, 0);

        // Will contain components of entity
        private Transform transform;

        // Properties
        protected float RotationDirection
        {
            get { return rotationDirection; }
            set
            {
                if ((value == 1f) || (value == 0f) || (value == -1f))
                    rotationDirection = (int)value;
                else
                    throw new ArgumentException(String.Format("{0} is not -1, 0 or 1", value), "value");
            }
        }
        protected float MoveSpeed
        {
            get { return moveSpeed; }
            set
            {
                if (value < 0 || value > maxSpeed)
                    throw new ArgumentOutOfRangeException();
                else
                    moveSpeed = value;
            }
        }
        protected float MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                else
                    maxSpeed = value;
            }
        }
        protected float RotationSpeed
        {
            get { return rotationSpeed; }
            set
            {
                if (value < 0 || value > maxRotationSpeed)
                    throw new ArgumentOutOfRangeException();
                else
                    rotationSpeed = value;
            }
        }
        protected float MaxRotationSpeed
        {
            get { return maxRotationSpeed; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                else
                    maxRotationSpeed = value;
            }
        }
    }
}
