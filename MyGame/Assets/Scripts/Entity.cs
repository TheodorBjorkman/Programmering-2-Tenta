using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Entity
{
    public class EntityBase : MonoBehaviour
    {
        [SerializeField] private int health = 10;
        protected Rigidbody rigidbody;
        protected int Health
        {
            get { return health; }
            set
            {
                int intVal = (int)value;
                if ((health - intVal) < 0)
                {
                    health = 0;
                    DeathEvent.Invoke();
                }
                else
                    health -= intVal;
            }
        }
        //Used events
        public UnityEvent DeathEvent;

        protected void StartEntity()
        {
            InitEvents();
            gameObject.AddComponent<Rigidbody>();
            rigidbody = gameObject.GetComponent<Rigidbody>() as Rigidbody;
            rigidbody.useGravity = false;
        }

        private void InitEvents()
        {
            if (DeathEvent == null)
                DeathEvent = new UnityEvent();
        }
    }
}