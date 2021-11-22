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
        public IEnumerator<UnityWebRequestAsyncOperation> GetRequest(string uri)
        {
            UnityWebRequest webRequest = UnityWebRequest.Get(uri);
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                    Debug.Log("Connection Error");
                    break;
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                    Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                    value = webRequest.downloadHandler.text;
                    break;
            }
        }

    }
}