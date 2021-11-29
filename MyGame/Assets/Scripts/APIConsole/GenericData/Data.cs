using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenericData
{
    public class Data<T>
    {
        public string name { get; set; }
        public T value { get; set; }
        public DataList<WeatherNode> weather { get; set; }
        public MainNode main { get; set; }
    }
}