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
        /// <summary>
        /// This the class that handles consoles. Allows for easier creation of consoles with different behaviour but the same i/o handling.
        /// </summary>
        void OnEndEdit()
        {
            ProcessInput(gameObject.GetComponent<TMP_InputField>().text);
        }
    }
}