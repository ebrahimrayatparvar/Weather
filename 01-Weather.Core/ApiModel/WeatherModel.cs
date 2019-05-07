using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Weather.Core.ApiModel
{
    public class WeatherModel
    {
        public string visibility { get; set; }
        public string @base { get; set; }
        public string dt { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string cod { get; set; }
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }
        public Main main { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public Sys sys { get; set; }

    }
    public class Coord
    {
        public string lon { get; set; }
        public string lat { get; set; }
    }
    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }
    public class Main
    {
        public double temp { get; set; }
        public string pressure { get; set; }
        public int humidity { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
    }
    public class Wind
    {
        public double? speed { get; set; }
        public double deg { get; set; }
    }
    public class Clouds
    {
        public int? all { get; set; }
    }
    public class Sys
    {
        public int? type { get; set; }
        public int? id { get; set; }
        public string message { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }        
    }
}
