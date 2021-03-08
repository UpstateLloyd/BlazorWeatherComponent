using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherAPI.Models;

namespace WeatherAPI.Services
{
    public class WeatherService
    {
        //Call IPService 
        //Call GeoService with _ipaddress.IP
        //Call NWSEndpointService with _usergeo.latitude.ToString(), _usergeo.longitude.ToString();
        //Call ForecastService with _nwsemodel.Properties.forecast
        public async Task<ForecastModel> GetWeatherAsync()
        {
            ForecastModel _forecast = new ForecastModel();
            ForecastService _forecastservice = new ForecastService();
            NWSEndpointModel _nwsemodel = new NWSEndpointModel();            
            NWSEndpointService _nwseservice = new NWSEndpointService();
            IPAddressModel _ipaddress = new IPAddressModel();
            IPService _ipservice = new IPService();
            UserGeolocationModel _usergeo = new UserGeolocationModel();
            GeoService _geoservice = new GeoService();

            //Call IPService 
            //Call GeoService with _ipaddress.IP
            //Call NWSEndpointService with _usergeo.latitude.ToString(), _usergeo.longitude.ToString();
            //Call ForecastService with _nwsemodel.Properties.forecast

            _ipaddress = await _ipservice.GetIPAsync();
            _usergeo = await _geoservice.GetLocationAsync(_ipaddress.IP);
            _nwsemodel = await _nwseservice.GetAPIEndpointAsync(_usergeo.latitude.ToString(), _usergeo.longitude.ToString());
            _forecast = await _forecastservice.GetForecastAsync(_nwsemodel.properties.forecast);

            return _forecast;
        }
    }
}
