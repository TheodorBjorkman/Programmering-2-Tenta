using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using API;
using UnityEngine.UI;
using GenericData;

namespace Console
{
    public partial class ConsoleIOHandler : APICallConsole
    {
        /// <summary>
        /// Handles the input from consoles, calls information and then formats it in a more readable way. Due to issues implementing JSon in Unity, current JSon parsing is manual.
        /// Could add commands into a list of a class containing potential subcommands.
        /// </summary>
        protected void ProcessInput(string input)
        {
            // Calls the command if it exists otherwise defaults.
            string[] inputArray = input.Split(' ');
            switch (inputArray[0])
            {
                // Commands exists in the ConsoleIOCommands file
                case "help":
                    Help(inputArray);
                    break;
                case "get":
                    Get(inputArray);
                    break;
                default:
                    Output("Invalid input: see help for commands");
                    break;
            }
        }
        void Update()
        {
            // Due to the asynchronous nature of api calls it was tricky to make it output when the api had responded because unity is single threaded, the current fix is to check if there is information in the json variable and in that case cleaning and then outputting it.
            if (json != null)
            {
                // Cleanweather is in the file ConsoleIOHandlerCleaning
                json = CleanWeather(json);
                Output(json);
                json = null;
            }
        }
        void Output(string input)
        {
            // Sets the named Search Output text component to the input text
            GameObject.Find("Search Output").GetComponent<Text>().text = input;
        }
    }
}