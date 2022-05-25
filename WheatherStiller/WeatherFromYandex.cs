using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStiller
{
    class WeatherFromYandex
    {
        public string GetWeather(string site)
        {
            string result = "Ошибка";
            int index = site.IndexOf("unit unit_temperature_");
            if (index >= 0)
            {
                site = site.Remove(0, index);
                index = site.IndexOf("</span>");
                site = site.Remove(0, index+7);
                result = site.Remove(site.IndexOf("<"));
                
            }
            return result;
        }
    }
}
