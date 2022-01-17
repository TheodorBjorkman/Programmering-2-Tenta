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
        /// Contains methods to clean up hard to read information as well as helper methods
        /// </summary>
        string CleanWeather(string input)
        {
            // Removes unwanted information and formats it in a more readable way, some unintended behaviour which removes some wanted information
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
        // Helper methods to remove all instances of one or more characters from a string depending on overload
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

