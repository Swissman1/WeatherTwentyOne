using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherTwentyOne.Models
{
    public class WeatherForecast
    {
        public LocationEntity Location { get; set; } = new LocationEntity();
        public List<ForecastValue> ForecastValues { get; set; } = new List<ForecastValue>();
        public void Add(ForecastValue forecast) => ForecastValues.Add(forecast);
    }
    public class LocationEntity
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? Elevation { get; set; } = 0;
        public LocationEntity(float latitude, float longitude, string name, int? elevation = 0)
        {
            Latitude = latitude;
            Longitude = longitude;
            Elevation = elevation;
            Name = name;
        }
        public LocationEntity()
        {

        }
    }
    public class ForecastValue
    {
        public ValidTime ValidTime { get; set; } = new ValidTime();
        public bool IsDayTime { get; set; } = true;
        public Parameter Temperature { get; set; } = new Parameter();
        public Parameter? RelativeHumidity { get; set; } = new Parameter();
        public Parameter? WindSpeed { get; set; } = new Parameter();
        public Parameter? WindDirection { get; set; } = new Parameter();
        public Parameter? ChanceRain { get; set; } = new Parameter();
        public Parameter? CloudCover { get; set; } = new Parameter();
        public string WeatherDesc { get; set; } = string.Empty;
        public WeatherType WeatherType { get; set; }
    }

    public enum WeatherType
    {
        Rain,
        ThunderStorms,
        MostlyClear,
        PartlyCloudy,
        Cloudy,
        Drizzle,
        Hail,
        Haze,
        Clear,
        RainSnowMix,
        Snow,
        Windy,
        Undefined,
        None,
        Fog
    }

    public class CurrentConditions
    {
        public Parameter Temp { get; set; }
        public Parameter Wind { get; set; }
        public Parameter Pressure { get; set; }
        public WeatherType WeatherType { get; set; }
    }
    public class Parameter
    {
        public Parameter() { }
        public Parameter(int value, string unit)
        {
            Value = value;
            Unit = unit;
        }

        public int Value { get; set; }
        public string Unit { get; set; } = string.Empty;

    }

    public class ValidTime
    {
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public ValidTime(DateTime start, DateTime? end = null)
        {
            Start = start;
            End = end;
        }
        public ValidTime()
        {

        }
    }
}
