using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public struct WeatherData
    {
        private string city;
        private string temperature;
        private string forecast;
        public override string ToString()
        {
            return "City: " + city + " " + "temperature: " + temperature + " " + "Forecast: " + forecast;
        }
    }
}
