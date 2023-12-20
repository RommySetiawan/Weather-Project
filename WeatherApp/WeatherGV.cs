using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class WeatherGV
    {
        public static string CityName {  get; set; }
        public static double CurTemp { get; set; }
        public static double FeelLike { get; set; }
        public static double TempMin { get; set; }
        public static double TempMax { get; set;}
        public static double WindSpeed { get; set; }
        public static double Direction { get; set; }
        public static string Description { get; set; }
        public static int Humidity { get; set; }
        public static int Pressure { get; set; }
        public static int SunRise { get; set; }
        public static int SunSet { get; set;}
    }
}
