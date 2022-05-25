using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStiller
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        string _site;
        SiteFromURL siteFrom;
        WeatherFromYandex weather;
        public ViewModel()
        {
            siteFrom = new SiteFromURL();
            weather = new WeatherFromYandex();
            string temp = siteFrom.GetSite("https://www.gismeteo.ru/");
            Site = weather.GetWeather(temp);
        }
        public string Site
        {
            get {  return _site; }
            set
            {
                _site = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Site"));
            }
        }
    }
}
