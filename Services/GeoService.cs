using WeatherAPI.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace WeatherAPI.Services
{
    public class GeoService
    {
        public async Task<UserGeolocationModel> GetLocationAsync(string userIP)
        {
            string api_key = "f5f3dea5dfce7dadbc84d572449d17b4";
            var client = new RestClient("http://api.ipstack.com/" + userIP + "?access_key=" + api_key);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);

            return JsonConvert.DeserializeObject<UserGeolocationModel>(response.Content);
        }
    }
}
