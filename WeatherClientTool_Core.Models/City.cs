﻿namespace WeatherClientTool_Core.Models
{
    public class City
    {
        public string? CityName { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longtitude { get; set; }
        public decimal Temperature { get; set; }
        public decimal Windspeed { get; set; }
        public decimal WindDirection { get; set; }
        public int WeatherCode { get; set; }

        public bool Status { get; set; }
        public string? Message { get; set; }

        public City() { }
    }
}