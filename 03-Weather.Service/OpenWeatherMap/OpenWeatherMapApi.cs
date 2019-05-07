using _01_Weather.Core.ApiModel;
using Newtonsoft.Json;
using System.Net;

namespace _03_Weather.Service.OpenWeatherMap
{
    public class OpenWeatherMapApi
    {
        #region Get weather information with open weather map api
        public WeatherModel GetApiResult(string cityName, string apiKey)
        {
            var url = $"http://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}";
            var client = new WebClient();
            var contact = client.DownloadString(url);
            return JsonConvert.DeserializeObject<WeatherModel>(contact);
        }
        #endregion

    }
}
