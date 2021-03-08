using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using WeatherAPI.Models;

namespace WeatherAPI.Services
{
    public class ForecastService
    {
        //https://api.weather.gov/gridpoints/BUF/64,38/forecast
        //

        public async Task<ForecastModel> GetForecastAsync(string endpoint)
        {
            var client = new RestClient(endpoint);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            client.UserAgent = "upstatelloyd@gmail.com";
            IRestResponse response = await client.ExecuteAsync(request);

            return JsonConvert.DeserializeObject<ForecastModel>(response.Content);
        }
    }
}
