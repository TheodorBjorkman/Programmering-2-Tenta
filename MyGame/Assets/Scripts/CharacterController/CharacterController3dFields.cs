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
        /// Fields of entity
        /// </summary>
        [SerializeField] private float rotationSpeed = 180f;
        [SerializeField] private float maxRotationSpeed = 360f;
        [SerializeField] private float gravity = -15f;
        [SerializeField] private float moveSpeed = 1f;
        [SerializeField] private float maxSpeed = 10f;
        // -1 is left, 1 is right, 0 is nothing.
        [SerializeField] private int rotationDirection = 0;
        // Wanted velocity, calculated in the move method.
        private Vector3 velocity = Vector3.zero;
        // Spawn position, default is 1 unit above the center or 0.5 units above ground.
        private Vector3 startPosition = new Vector3(0, 1, 0);
        // The default material set and used upon awakening.
        private Material defaultM;
        // Transform of entity
        private Transform transform;

        /// <summary>
        /// Properties of the entity. Conatins a get method and constrained set method to keep values valid
        /// </summary>
        public float RotationDirection
        {
            get { return rotationDirection; }
            // Allows only -1, 0 or 1 for left (counter clockwise), no rotation and right (clockwise) respectively
            set
            {
                if ((value == 1f) || (value == 0f) || (value == -1f))
                    rotationDirection = (int)value;
                else
                    throw new ArgumentException($"{value} is not -1, 0 or 1", "value");
            }
        }
        public float MoveSpeed
        {
            get { return moveSpeed; }
            // Movement speed is directionless and is therefore only capable of being set to positive values. 
            // To prevent too high speeds unintentionally the movement speed needs to be lower than a max speed.
            set
            {
                if (value < 0 || value > maxSpeed)
                    throw new ArgumentOutOfRangeException();
                else
                    moveSpeed = value;
            }
        }
        public float MaxSpeed
        {
            get { return maxSpeed; }
            // Since speed is supposed to be positive, max speed has to be positive too.
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                else
                    maxSpeed = value;
            }
        }
        public float RotationSpeed
        {
            get { return rotationSpeed; }
            // Rotation speed is, similarly to movement speed, supposed to be between 0 and max rotational speed to stop unintended behaviour
            set
            {
                if (value < 0 || value > maxRotationSpeed)
                    throw new ArgumentOutOfRangeException();
                else
                    rotationSpeed = value;
            }
        }
        public float MaxRotationSpeed
        {
            get { return maxRotationSpeed; }
            // Rotational speed is supposed to be positive, max rotation speed has to be positive.
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
