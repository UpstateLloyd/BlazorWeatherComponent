using RestSharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherAPI.Models;

namespace WeatherAPI.Services
{
    public class NWSEndpointService
    {
        public async Task<NWSEndpointModel> GetAPIEndpointAsync(string latitude, string longitude)
        {
            string APIEndpoint = "https://api.weather.gov/points/" + latitude.Substring(0,latitude.IndexOf(".") + 5) + "," + longitude.Substring(0, latitude.IndexOf(".") + 5);
            var client = new RestClient(APIEndpoint);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            client.UserAgent = "upstatelloyd@gmail.com";
            IRestResponse response = await client.ExecuteAsync(request);
            NWSEndpointModel _nwsemodel = new NWSEndpointModel();            
            return JsonConvert.DeserializeObject<NWSEndpointModel>(response.Content);


        }
    }
}
