using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GenericData;

public class WeatherNode : MonoBehaviour
{
    public int id { get; set; }
    public string main { get; set; }
    public string description { get; set; }
    public string icon { get; set; }

    /*
    "weather":
    [
        {
            "id":803,
            "main":"Clouds",
            "description":"broken clouds",
            "icon":"04d"
        }
    ]
    */
}
