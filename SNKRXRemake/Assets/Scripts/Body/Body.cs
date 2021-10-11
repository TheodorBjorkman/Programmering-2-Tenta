using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Body
{
    public class Body : MonoBehaviour
    {
        [SerializeField] private int moveSpeed;
        [SerializeField] private int health;
        [SerializeField] private int level;
        private Vector3 moveDirection;
        private Rigidbody2D m_Rigidbody2D;
        private bool newSpawn = true;
    }
}
