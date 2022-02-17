using System.Linq.Expressions;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Threading;
using UnityEngine.Networking;

namespace Weather
{
    public class WeatherData
    {
        public string value;
        /// <summary>
        /// Asyncronous method for calling api, I did not write most of this but it is edited and I have tried a few other solutions that Unity did not like
        /// </summary>
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