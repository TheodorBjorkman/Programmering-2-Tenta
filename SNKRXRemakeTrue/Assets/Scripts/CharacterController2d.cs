using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterController2d : MonoBehaviour
{
    // Fields of entity
    [SerializeField] private float rotationSpeed = 45f;     // Rotation speed of entity
    [Range(0, .3f)] [SerializeField] private float movementSmoothing = .05f;        // How much to smooth out turning
    [SerializeField] private LayerMask whatIsWall;      // A mask determining what is a wall to the entity
    [SerializeField] private float gravity = -15f;      // Force of gravity
    [SerializeField] private float moveSpeed = 10f;     // Movement speed of the entity
    [SerializeField] private int rotationDirection = 0;
    // protected float MoveSpeed 
    // {
    //     get { return moveSpeed; }
    //     set 
    //     {
    //         if ((value != 1) || (value != 0) || (value != -1))
    //             throw new ArgumentException(String.Format("{0} is not -1, 0 or 1", value), "value");
    //         else 
    //             moveSpeed = value; 
    //     }
    // }
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
            if ((value != 1) || (value != 0) || (value != -1))
                throw new ArgumentException(String.Format("{0} is not -1, 0 or 1", value), "value");
            else 
                RotationDirection = value; 
        }
    }

    [Header("Events")]
    [Space]

    public UnityEvent TouchWallEvent;

    // Start is called before the first frame update
    void Start()
    {
        StartController();
    }
    protected void StartController()
    {
        rigidbody = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();

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
        velocity = transform.forward * moveSpeed;
        rigidbody.velocity = (rigidbody.velocity - new Vector3(rigidbody.velocity.x, 0, rigidbody.velocity.z)) + velocity;
        rigidbody.AddForce(new Vector3(0, gravity, 0));
        transform.Rotate(new Vector3(0, rotationDirection, 0) * Time.deltaTime * rotationSpeed);
    }
}
