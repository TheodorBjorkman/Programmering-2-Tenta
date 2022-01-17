using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Entity
{
    public class EntityBase : MonoBehaviour
    {
        /// <summary>
        /// Base class for Entities.
        /// </summary>
        private int health = 10;
        private Rigidbody rigidbody;
        public int Health
        {
            get { return health; }
            // Set method avoids negative health
            set
            {
                int intVal = value;
                if (health < intVal)
                {
                    health = 0;
                }
                else
                    health = intVal;
            }
        }
        // No need to change rigidbody's value so it's read only.
        public Rigidbody Rigidbody { get { return rigidbody; } }
        // Awake is called upon instantiation.
        private void Awake()
        {
            StartEntity();
        }
        // Adds rigidbody, disables Unity's own gravity for more specific control.
        protected void StartEntity()
        {
            gameObject.AddComponent<Rigidbody>();
            rigidbody = gameObject.GetComponent<Rigidbody>() as Rigidbody;
            rigidbody.useGravity = false;
        }
    }
}