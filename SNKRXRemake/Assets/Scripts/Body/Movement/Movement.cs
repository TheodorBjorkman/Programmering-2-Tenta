using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Body
{
    public class Movement : Body
    {
        void Update()
        {
           

        }
        public void Move() 
        {
            Vector2 targetVel = new Vector2(moveDirection.x*moveSpeed, moveDirection.y*moveSpeed);
        }
    }

}
