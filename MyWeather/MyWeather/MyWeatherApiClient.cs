using System;
using Refit;
using MyWeather.Model;
using System.Threading.Tasks;

namespace MyWeather
{
    public interface IMyWeatherApiClient
    {
        [Get("/v1/current.json?key={apikey}&q={cityName}")]
        Task<WeatherResponse> GetWeatherFromCity(string cityName, string apikey);
    }
}
