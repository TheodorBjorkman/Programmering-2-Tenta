using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Body
{
    public class Body : MonoBehaviour
    {
        [SerializeField] protected int moveSpeed = 1;
        [SerializeField] private int health;
        [SerializeField] private int level;
        [SerializeField] private LayerMask whatIsWall;
        [SerializeField] private Transform wallCheck;
        protected Vector2 moveDirection = new Vector2(0.0f, 0.0f);
        private Rigidbody2D m_Rigidbody2D;
        private bool newSpawn = true;

        [Header("Events")]
        [Space]

        public UnityEvent OnWallEvent;
        public UnityEvent OnHitEvent;

        private void Awake()
        {
            m_Rigidbody2D = GetComponent<Rigidbody2D>();

            if (OnWallEvent == null)
                OnWallEvent = new UnityEvent();

            if (OnHitEvent == null)
                OnHitEvent = new UnityEvent();
        }
    }
}
