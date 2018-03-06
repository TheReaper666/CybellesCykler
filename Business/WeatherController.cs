using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;

namespace Business
{
    public class WeatherController
    {
        private readonly string url = "http://api.openweathermap.org/data/2.5/forecast?id=2625070&units=metric&type=accurate&APPID=";
        private readonly string apiKey = "95e4391dfdca9621437068fdf13ef372";

        public WeatherController(string url, string apiKey)
        {

        }
        //public WeatherData TodaysWeather()
        //{

        //}
        //public WeatherData TomorrowsWeather()
        //{

        //}
    }
}
