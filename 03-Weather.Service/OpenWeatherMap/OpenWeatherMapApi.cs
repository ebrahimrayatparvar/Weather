using _01_Weather.Core.ApiModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace _03_Weather.Service.OpenWeatherMap
{
    public class OpenWeatherMapApi
    {
        public WeatherModel GetApiResult(string cityName, string apiKey)
        {
            var url = $"http://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}";
            var client = new WebClient();
            var contact = client.DownloadString(url);
            return JsonConvert.DeserializeObject<WeatherModel>(contact);
        }
        
    }
}
