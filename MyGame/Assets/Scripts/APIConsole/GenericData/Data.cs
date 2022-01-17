using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenericData
{
    public class Data<T>
    {
        /// <summary>
        /// A generic class for storage of a key:value pair with a generic value and a string key.
        /// </summary>
        public string Key { get; set; }
        public T Value { get; set; }
        private string type = $"{T}";
        public string Type { get { return type; } }
    }
}