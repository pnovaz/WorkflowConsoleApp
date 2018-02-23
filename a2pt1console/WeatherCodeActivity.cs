using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.Web;
using System.Net;
using System.Web.Extensions;

namespace a2pt1console
{
    //this code activity calls rest api to retrieve weather information!
    public sealed class WeatherCodeActivity : CodeActivity
    {
        // Define an activity input argument of type string
        public InArgument<string> city { get; set; } //user enters a city name or zipcode

        public OutArgument<string> result { get; set; }
        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            // Obtain the runtime value of the Text input argument

            Console.WriteLine("Please enter the city name or zip code.");

            string txtCity = Console.ReadLine();

           string weatherInfo = getWeatherInfo(txtCity);

            context.SetValue(this.result, weatherInfo);

        }

        public class WeatherInfo
        {
            public City city { get; set; }
            public List<List> list { get; set; }
        }

        public class City
        {
            public string name { get; set; }
            public string country { get; set; }
        }

        public class Temp
        {
            public double day { get; set; }
            public double min { get; set; }
            public double max { get; set; }
            public double night { get; set; }
        }

        public class Weather
        {
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class List
        {
            public Temp temp { get; set; }
            public int humidity { get; set; }
            public List<Weather> weather { get; set; }
        }

        public string getWeatherInfo(string txtCity)
        {
            string appId = "70305fd5ca5d0947ffc7934cfa248bb1";
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&units=metric&cnt=1&APPID={1}", txtCity.Text.Trim(), appId);

            using (WebClient client = new WebClient())
            {

                string json = client.DownloadString(url);

                WeatherInfo weatherInfo = (new JavaScriptSerializer()).Deserialize<WeatherInfo>(json);


                string cityCountry = weatherInfo.city.name + "," + weatherInfo.city.country;
                //imgCountryFlag.ImageUrl = string.Format("http://openweathermap.org/images/flags/{0}.png", weatherInfo.city.country.ToLower());
                string weatherDescription = weatherInfo.list[0].weather[0].description;
                //imgWeatherIcon.ImageUrl = string.Format("http://openweathermap.org/img/w/{0}.png", weatherInfo.list[0].weather[0].icon);
                string minTemp = string.Format("{0}°С", Math.Round(weatherInfo.list[0].temp.min, 1));
                string maxTemp = string.Format("{0}°С", Math.Round(weatherInfo.list[0].temp.max, 1));
                string day = string.Format("{0}°С", Math.Round(weatherInfo.list[0].temp.day, 1));
                string nightTemp = string.Format("{0}°С", Math.Round(weatherInfo.list[0].temp.night, 1));
                string humidity = weatherInfo.list[0].humidity.ToString();
                //tblWeather.Visible = true;

                string result = "For " + cityCountry + " " + WeatherDescription + " The low for today is: " + minTemp + "the high for today is " + maxTemp + " and tonight it is expected to be " +
                nightTemp + " Currently the humidity is: " + humidity;
                return result;
            }
        }
    }
}