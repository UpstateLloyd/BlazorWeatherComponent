using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAPI.Models
{
    
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class NWSEGeometry
        {
            public string type { get; set; }
            public List<double> coordinates { get; set; }
        }

        public class Distance
        {
            public double value { get; set; }
            public string unitCode { get; set; }
        }

        public class Bearing
        {
            public int value { get; set; }
            public string unitCode { get; set; }
        }

        public class Subproperties
        {
            public string city { get; set; }
            public string state { get; set; }
            public Distance distance { get; set; }
            public Bearing bearing { get; set; }
        }

        public class RelativeLocation
        {
            public string type { get; set; }
            public NWSEGeometry geometry { get; set; }
            public Subproperties subproperties { get; set; }
        }

        public class NWSEProperties
        {
            [JsonProperty("@id")]
            public string Id { get; set; }
            [JsonProperty("@type")]
            public string Type { get; set; }
            public string cwa { get; set; }
            public string forecastOffice { get; set; }
            public string gridId { get; set; }
            public int gridX { get; set; }
            public int gridY { get; set; }
            public string forecast { get; set; }
            public string forecastHourly { get; set; }
            public string forecastGridData { get; set; }
            public string observationStations { get; set; }
            public RelativeLocation relativeLocation { get; set; }
            public string forecastZone { get; set; }
            public string county { get; set; }
            public string fireWeatherZone { get; set; }
            public string timeZone { get; set; }
            public string radarStation { get; set; }
        }

        public class NWSEndpointModel
        {
            [JsonProperty("@context")]
            public List<object> Context { get; set; }
            public string id { get; set; }
            public string type { get; set; }
            public NWSEGeometry geometry { get; set; }
            public NWSEProperties properties { get; set; }
        }
        
}
