using System;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : ICustomObserver, IDisplay
    {
        private double _temperature;
        private double _humidity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }
        public void Update(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }

        public void PullUpdate()
        {

        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature} C and humdity {_humidity}");
        }

    }
}
