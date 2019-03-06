using System;
using System.Collections.Generic;
using System.Linq;

namespace ObserverPattern
{
    public class StatisticsDisplay : ICustomObserver, IDisplay
    {
        private double _temperature;
        private double _maxTemperature = double.MinValue;
        private double _minTemperature = double.MaxValue;
        private double _avgTemperature;
        private ISubject _weatherData;
        private List<double> _temperatures;

        public StatisticsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
            _temperatures = new List<double>();
        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min/Current Temperatures: {_avgTemperature}/{_maxTemperature}/{_minTemperature}/{_temperature}");
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            Calculate();
            Display();
        }

        private void Calculate()
        {
            _maxTemperature = Math.Max(_maxTemperature, _temperature);
            _minTemperature = Math.Min(_minTemperature, _temperature);
            _temperatures.Add(_temperature);
            _avgTemperature = _temperatures.Average();
        }
    }
}
