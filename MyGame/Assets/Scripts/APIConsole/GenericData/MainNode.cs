using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenericData
{
    public class MainNode
    {
        public float temp { get; set; }
        public float feels_like { get; set; }
        public float temp_min { get; set; }
        public float temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
    }
}