using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenericData
{
    public class Data<T>
    {
        string name {   get;    set;    }
        T value {   get;    set;    }
        DataList<WeatherNode> weather = new DataList<WeatherNode>();
        MainNode main = new MainNode();
    }
}