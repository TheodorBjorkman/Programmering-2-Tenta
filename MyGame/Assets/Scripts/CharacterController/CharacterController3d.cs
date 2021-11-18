using System.Diagnostics;
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
            gameObject.AddComponent<MeshRenderer>();
            MeshRenderer meshR = gameObject.GetComponent<MeshRenderer>();
            Material defaultM = Resources.Load<Material>("/Concrete textures pack/pattern 01/Concrete pattern 01.mat");
            meshR.material = defaultM;
            UnityEngine.Debug.Log(meshR.material);     //???????????? For some reason if I don't log the material it wont render or smthng idk
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