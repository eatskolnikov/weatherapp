using System;
namespace MyWeather.Model
{
    public class Condition
    {
        public string text { get; set; }
        public string icon { get; set; }
        public string IconUrl
        {
            get
            {
                return $"https:{icon}";
            }
        }
    }
}
