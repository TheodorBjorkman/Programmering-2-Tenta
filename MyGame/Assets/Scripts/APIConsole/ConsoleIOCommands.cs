using System.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using API;
using UnityEngine.UI;

namespace Console
{
    public partial class ConsoleIOHandler : APICallConsole
    {
        /// <summary>
        /// Contains the commands that are executable from the console.
        /// </summary>
        void Help(string[] inputArray)
        {
            // Help should contain a list of all commands as well as an explanation of syntax and function.
            if (inputArray.Length < 2)
            {
                Output("Availible commands: help, get");
                return;
            }
            switch (inputArray[1])
            {
                case "get":
                    Output("Prints data. Example: \"get weather\". Data that can be fetched: weather");
                    break;
                default:
                    Output("Invalid syntax, help availible for: get");
                    break;
            }
        }
        void Get(string[] inputArray)
        {
            if (inputArray.Length < 2)
            {
                Output("Invalid syntax: use \"help get\" for more information");
                return;
            }
            switch (inputArray[1])
            {
                case "weather":
                    // SendMessage method is a method inherited from MonoBehaviour that calls the method that is written in the arguments on the gameobject that it is called on (currently gameObject which is the gameobject this script instance is attached to)
                    gameObject.SendMessage("GetWeather");
                    break;
                default:
                    Output($"Invalid syntax: cannot get {inputArray[1]}. Use \"help get\" for retrievable values.");
                    break;
            }
        }
    }
}