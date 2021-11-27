using System.Linq.Expressions;
using System.Collections.Generic;
using UnityEngine;
using GenericData;
using System.IO;
using System.Threading;
using UnityEngine.Networking;

namespace Weather
{
    public class WeatherData
    {
        public string value;
        public IEnumerator<UnityWebRequestAsyncOperation> GetRequest(string url)
        {
            UnityWebRequest webRequest = UnityWebRequest.Get(url);
            yield return webRequest.SendWebRequest();
            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                    Debug.Log("Connection Error");
                    break;
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError("Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError("HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                    Debug.Log("Received: " + webRequest.downloadHandler.text);
                    value = webRequest.downloadHandler.text;
                    break;
            }
        }

    }
}