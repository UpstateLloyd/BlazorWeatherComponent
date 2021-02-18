using Newtonsoft.Json;
using RestSharp;
using System;
using System.Linq;
using System.Threading.Tasks;
using WeatherAPI.Models;

namespace WeatherAPI.Data
{
    public class ForecastService
    {
        public async Task<ForecastModel> GetForecastAsync()
        {
            var client = new RestClient("https://api.weather.gov/gridpoints/BUF/61,42/forecast");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            client.UserAgent = "upstatelloyd@gmail.com";
            IRestResponse response = await client.ExecuteAsync(request);

            return JsonConvert.DeserializeObject<ForecastModel>(response.Content);
        }
    }
}
