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
        protected void GetWeather()
        {
            gameObject.SendMessage("Call");
        }
        void Update()
        {
            if (json != null)
            {
                Deserialize(json);
                GameObject.Find("Search Output").GetComponent<Text>().text = json;
                json = null;
            }
        }
        string Deserialize(string input) 
        {
            string output = input;
            Data<string> data = JsonUtility.FromJson<Data<string>>(json);
            return output;
        }
    }
}