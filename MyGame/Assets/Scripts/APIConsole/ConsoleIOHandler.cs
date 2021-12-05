using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using API;
using UnityEngine.UI;
using GenericData;

namespace Console
{
    public class ConsoleIOHandler : APICallConsole
    {
        protected void ProcessInput(string input)
        {
            string[] inputArray = input.Split(' ');
            switch (inputArray[0])
            {
                case "help":
                    if (inputArray.Length > 1)
                    {
                        Help(inputArray);
                        break;
                    }
                    Output("Availible commands: help, get");
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
            if (json != null)
            {
                json = CleanWeather(json);
                Output(json);
                json = null;
            }
        }
        void Output(string input)
        {
            GameObject.Find("Search Output").GetComponent<Text>().text = input;
        }
        void Help(string[] inputArray)
        {
            switch (inputArray[1])
            {
                case "get":
                    Output("Get data. Example: \"get weather\". Data that can be fetched: weather");
                    break;
                default:
                    break;
            }
        }
        void Get(string[] inputArray)
        {
            if (inputArray.Length < 2)
            {
                Output("Invalid syntax: use \"help get\" for correct usage");
                return;
            }
            switch (inputArray[1])
            {
                case "weather":
                    gameObject.SendMessage("GetWeather");
                    break;
                default:
                    Output($"Invalid syntax: cannot get {inputArray[1]}. See help get for retrievable values.");
                    break;
            }
        }
        string CleanWeather(string input)
        {
            input = input.Remove(0, input.IndexOf("description"));
            input = input.Remove(input.IndexOf("icon"), input.IndexOf("main") - 8);
            input = input.Remove(input.IndexOf("visibility"));
            char[] charsToClean = new char[] { '[', ']', '(', ')', '{', '}', '}' };
            input = RemoveCharacter(input, charsToClean);
            input = input.Replace("\"", "");
            input = input.Replace(",", "\n");
            input = String.Join("", input.Split('"'));
            return input;
        }
        string RemoveCharacter(string input, char rem)
        {
            if (input.Contains(rem.ToString()))
                input = input.Remove(input.IndexOf(rem), 1);
            return input;
        }
        string RemoveCharacter(string input, char[] rem)
        {
            foreach (char item in rem)
            {
                if (input.Contains(item.ToString()))
                    input = input.Remove(input.IndexOf(item), 1);
            }
            return input;
        }
    }
}