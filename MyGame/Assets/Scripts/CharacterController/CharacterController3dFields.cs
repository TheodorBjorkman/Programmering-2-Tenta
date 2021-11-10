using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CharacterController 
{
    public partial class CharacterController3d : MonoBehaviour
    {
        // Fields of entity
        [SerializeField] private float rotationSpeed = 180f;     // Rotation speed of entity
        [SerializeField] private LayerMask whatIsWall;      // A mask determining what is a wall to the entity
        [SerializeField] private float gravity = -15f;      // Force of gravity
        [SerializeField] private float moveSpeed = 1f;     // Movement speed of the entity
        [SerializeField] private float maxSpeed = 100f;
        [SerializeField] private int rotationDirection = 0;
        private Vector3 velocity = Vector3.zero;

        // Will be components of entity
        private Rigidbody rigidbody;
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
                    throw new IndexOutOfRangeException();
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
                    throw new IndexOutOfRangeException();
                else 
                    maxSpeed = value; 
            }
        }

        [Header("Events")]
        [Space]

        public UnityEvent TouchWallEvent;
    }
}
