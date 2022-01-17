using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weather;
using UnityEngine.Networking;

namespace API
{
    public class APICallConsole : MonoBehaviour
    {
        /// <summary>
        /// Makes api calls for the console. 
        /// </summary>
        protected string json;
        protected IEnumerator GetWeather()
        {
            WeatherData wD = new WeatherData();
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Stockholm&appid=9579601d92b924d4099ae5dbaf27aaa6";
            yield return StartCoroutine(wD.GetRequest(url));
            json = wD.value;
        }
    }
}