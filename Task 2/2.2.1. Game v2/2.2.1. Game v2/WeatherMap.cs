using System;
using System.Collections.Generic;
using System.Text;

namespace _2._2._1._Game_v2
{
    class WeatherMap : Map
    {
        public new void Prepare()
        {
            base.Prepare();
            this.EnableRainWeather();
        }
        public void EnableRainWeather()
        {
            Console.WriteLine("Дождь включен!");
        }

        public void DisableRainWaither()
        {
            Console.WriteLine("Дождь выключен!");
        }
    }
}
