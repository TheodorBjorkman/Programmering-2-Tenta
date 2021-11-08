using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterController2d : MonoBehaviour
{
    [SerializeField] private float m_RotationSpeed = 45f;   // Rotation speed of entity
    [SerializeField] private float m_MoveSpeed = 1f;                          // Movement speed of the entity
    [Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;  // How much to smooth out turning
    [SerializeField] private LayerMask m_WhatIsWall;                          // A mask determining what is a wall to the entity

    private Rigidbody2D m_Rigidbody2D;
    private Transform m_Transform;
    private Vector3 m_Velocity = Vector3.zero;

    float rotationDirection = 0f;

    [Header("Events")]
    [Space]

    public UnityEvent TouchWallEvent;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
        m_Transform = GetComponent<Transform>();

        if (TouchWallEvent == null)
            TouchWallEvent = new UnityEvent();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Update is called at fixed intervals
    void FixedUpdate()
    {
        rotationDirection = Input.GetAxisRaw("Horizontal");
        Move();
    }

    // Movement
    void Move()
    {
        m_Transform.Rotate(new Vector3(0, 0, rotationDirection) * Time.deltaTime * m_RotationSpeed);
    }
}
