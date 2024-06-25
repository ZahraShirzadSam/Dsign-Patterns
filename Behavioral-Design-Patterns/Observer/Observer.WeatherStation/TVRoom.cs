﻿
using Observer.WeatherStation.Abstractions;

namespace Observer.WeatherStation
{
    public class TVRoom : IObserver
    {
        public void Update(IObservable obs)
        {
            if (obs is WeatherStationObservable workstation)
            {
                Console.WriteLine("TVRoom,{0}", workstation.Temprature);
            }
        }
    }
}
