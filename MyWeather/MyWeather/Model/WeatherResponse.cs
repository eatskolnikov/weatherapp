using System;
namespace MyWeather.Model
{
    public class WeatherResponse
    {
        public Location location { get; set; }
        public Weather current { get; set; }
    }
}
