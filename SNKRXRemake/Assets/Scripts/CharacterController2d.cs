using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterController2d : MonoBehaviour
{
    [SerializeField] private float m_MoveSpeed = 1f;                          // Movement speed of the entity
    [Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;  // How much to smooth out turning
    [SerializeField] private LayerMask m_WhatIsGround;                          // A mask determining what is a wall to the entity

    private Rigidbody2D m_Rigidbody2D;
    private Vector2 m_Velocity = Vector2.zero;

    [Header("Events")]
    [Space]

    public UnityEvent TouchWallEvent;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();

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

    }
}
