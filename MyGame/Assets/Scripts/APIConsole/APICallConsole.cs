using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weather;
using UnityEngine.Networking;

namespace API
{
    public class APICallConsole : MonoBehaviour
    {
        string raw;
        protected string GetWeather()
        {
            Call("https://api.openweathermap.org/data/2.5/weather?q=Stockholm&appid=9579601d92b924d4099ae5dbaf27aaa6");
            return raw;
        }

        protected IEnumerator Call(string API)
        {
            WeatherData wD = new WeatherData();
            yield return StartCoroutine(wD.GetRequest(API));
            raw = wD.value;
        }
    }
}