using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using API;
using TMPro;

namespace Console
{
    public class BaseConsole : ConsoleIOHandler
    {
        void OnEndEdit()
        {
            GetWeather();
        }
    }
}