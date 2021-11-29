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
                json = Deserialize(json);
                GameObject.Find("Search Output").GetComponent<Text>().text = json;
                json = null;
            }
        }
        string Deserialize(string input)
        {
            string output;
            Data<string> data = JsonUtility.FromJson<Data<string>>(input);
            output = data.weather.value[0].description;
            return output;
        }
    }
}