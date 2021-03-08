using WeatherAPI.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAPI.Services
{
    public class IPService
    {
        public async Task<IPAddressModel> GetIPAsync()
        {
            var client = new RestClient("https://jsonip.com");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);

            return JsonConvert.DeserializeObject<IPAddressModel>(response.Content);
        }
    }
}
