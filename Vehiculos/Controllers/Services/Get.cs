using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace Vehiculos.Controllers.Services
{
    public class Get<T>
    {
        public T get(string url)
        {
            try
            {
                var client = new RestClient(url);
                var response = client.Execute(new RestRequest());

                object obj = JsonConvert.DeserializeObject(response.Content);
                T clase = JsonConvert.DeserializeObject<T>(obj.ToString());

                return clase;
            }
            catch
            {
                return default(T);
            }
        }
    }
}