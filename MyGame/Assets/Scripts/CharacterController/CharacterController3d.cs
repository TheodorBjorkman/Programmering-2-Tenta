using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Entity;

namespace CharacterController 
{
    public partial class CharacterController3d : EntityBase
    {
        // Start is called before the first frame update
        void Start()
        {
            StartController();
        }

        protected void StartController()
        {
            transform = gameObject.GetComponent<Transform>() as Transform;
            transform.position = startPosition;
            MeshRenderer meshR = gameObject.AddComponent<MeshRenderer>();
            Material dMat = (Material)Resources.Load("Default-Material", typeof(Material));     // Repurposed from https://answers.unity.com/questions/151178/get-material-from-the-library-at-runtime.html
            StartEntity();
        }

        // Update is called at fixed intervals
        void FixedUpdate()
        {
            Move();
            Rotate();
            Gravity();
        }
    }
}