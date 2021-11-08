using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterController2d : MonoBehaviour
{
    [SerializeField] private float m_RotationSpeed = 45f;   // Rotation speed of entity
    [Range(0, 1f)] [SerializeField] private float m_MoveSpeed = 1f;                          // Movement speed of the entity
    [Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;  // How much to smooth out turning
    [SerializeField] private LayerMask m_WhatIsWall;                          // A mask determining what is a wall to the entity
    [SerializeField] private float gravity = -15f;

    private Rigidbody m_Rigidbody;
    private Transform m_Transform;
    private Vector3 m_Velocity = Vector3.zero;

    [SerializeField] protected float rotationDirection = 0f;

    [Header("Events")]
    [Space]

    public UnityEvent TouchWallEvent;

    // Start is called before the first frame update
    protected void StartController()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Transform = GetComponent<Transform>();

        if (TouchWallEvent == null)
            TouchWallEvent = new UnityEvent();
    }

    // Update is called at fixed intervals
    void FixedUpdate()
    {
        Move();
    }

    // Movement
    protected void Move()
    {
        m_Transform.Rotate(new Vector3(0, rotationDirection, 0) * Time.deltaTime * m_RotationSpeed);
        m_Rigidbody.AddForce(m_Velocity + new Vector3(0, gravity, 0));
    }
}
