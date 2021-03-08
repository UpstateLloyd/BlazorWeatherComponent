using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace WeatherAPI.Models
{
    public class IPAddressModel
    {
        [JsonPropertyName("ip")]
        public string IP { get; set; }
        [JsonPropertyName("geo-ip")]
        public string GeoIP { get; set; }
        [JsonPropertyName("API Help")]
        public string APIHelp { get; set; }
    }
}
