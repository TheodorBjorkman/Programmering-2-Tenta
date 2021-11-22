using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using API;

namespace Console
{
    public class BaseConsole : ConsoleIOHandler
    {
        void Call()
        {
            GameObject output = GameObject.Find("Search Output");
            output.GetComponent<Text>().text = GetWeather();
        }
    }
}