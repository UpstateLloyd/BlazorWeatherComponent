using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAPI.Models
{
    public class WeatherDefinitions
    {
        public string[] WeatherArray = new string[26] {"sunny", "cloudy", "cloudy-gusts", "cloudy-windy", "fog", "hail", 
        "haze", "lightning", "rain", "rain-mix", "rain-wind", "showers", "sleet", "sleet-storm", "snow", "snow-thunderstorm",
        "snow-wind", "sprinkle", "storm-showers", "sunny-overcast", "thunderstorm", "windy", "hot", "light-wind",
        "clear", "partly-cloudy" };
    } 
}
