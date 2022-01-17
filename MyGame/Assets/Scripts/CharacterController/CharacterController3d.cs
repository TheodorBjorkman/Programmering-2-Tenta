using System.Diagnostics;
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
        /// Contains the main methods of the Character controller. These decide what happens and when it happens.
        /// </summary>
        // Awake is called upon instantiation.
        void Awake()
        {
            StartController();
        }
        // Creates meshrenderer, sets variables transform, meshR and defaultM as well as setting position and material to default position and material.
        protected void StartController()
        {
            transform = gameObject.GetComponent<Transform>() as Transform;
            transform.position = startPosition;
            defaultM = Resources.Load<Material>("/Concrete textures pack/pattern 01/Concrete pattern 01.mat");
            gameObject.AddComponent<MeshRenderer>();
            MeshRenderer meshR = gameObject.GetComponent<MeshRenderer>();
            meshR.material = defaultM;
            UnityEngine.Debug.Log(meshR.material);     // For some reason if the material isn't logged it won't work properly
            StartEntity();
        }

        // Update is called at fixed intervals
        void FixedUpdate()
        {
            Move();
            Rotate();
            ApplyGravity();
        }
    }
}