using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GetWeatherForecast
    {
        private string url;
        private string apiKey;

        public GetWeatherForecast(string url, string apiKey)
        {
            Url = url;
            ApiKey = apiKey;
        }

        //public WeatherData TodaysWeather()
        //{

        //}

        //public WeatherData TomorrowsWeather()
        //{

        //}

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public string ApiKey
        {
            get { return apiKey; }
            set { apiKey = value; }
        }
    }
}
