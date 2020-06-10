using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace Weather.Models
{
    public class Weather
    {
        public Object getWeatherForcast()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Almaty&APPID=0dc1a5d28545b241378bdc65221fbc91&units=metric";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}