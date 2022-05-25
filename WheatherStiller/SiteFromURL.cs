using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WeatherStiller
{
    class SiteFromURL
    {
        public string GetSite(string url)//комуниздим погоду с сайта
        {
            string result = "";
            WebRequest request = WebRequest.Create(url);//делаем запрос на сервер
            WebResponse response = request.GetResponse();//с запроса получаем ответ от сервера, получаем поток
            Stream stream = response.GetResponseStream();//получаем поток
            StreamReader reader = new StreamReader(stream);//читает данные
            result = reader.ReadToEnd();//читаем до конца
            return result;//вызвращаем значение
        }
    }
}
