using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Http;
using GenericData;
using System.IO;
using System.Threading;

public class WeatherData : MonoBehaviour
{
    static readonly HttpClient client = new HttpClient();
    DataList<string> dataList = new DataList<string>();
    string keyAPI = "9579601d92b924d4099ae5dbaf27aaa6";
    string cityName = "Stockholm";
    // protected int temp    {   get;    private set;    }
    // protected int tempMin    {   get;    private set;    }
    // protected int tempMax    {   get;    private set;    }
    // protected int feelsLike    {   get;    private set;    }
    // protected int pressure    {   get;    private set;    }
    // protected int humidity    {   get;    private set;    }
    // protected int windSpeed    {   get;    private set;    }

    public void UpdateData(string name)
    {
        Data<string> test = new Data<string>();
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.openweathermap.org/data/2.5/weather?q=Stockholm&appid=9579601d92b924d4099ae5dbaf27aaa6");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string jsonResponse = reader.ReadToEnd();
        WeatherInfo info = JsonUtility.FromJson<WeatherInfo>(jsonResponse);
        Debug.Log(info.weather[0].main);
    }

    static async void Test()
    {
        try	
        {
            Debug.Log("Trying");
            string responseBody = await client.GetFromJsonAsync("https://api.openweathermap.org/data/2.5/weather?q=Stockholm&appid=9579601d92b924d4099ae5dbaf27aaa6");
            Debug.Log(responseBody);
        }
        catch(HttpRequestException e)
        {
            Debug.Log("\nException Caught!");	
            //  Debug.Log("Message :{0} ",e.Message);
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
            Test();
    }

}

      public class Weather
      {
          public int id;
          public string main;
      }

      public class WeatherInfo
      {
          public int id;
          public string name;
          public List<Weather> weather;
      }