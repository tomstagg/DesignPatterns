using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        private List<ICustomObserver> _observers;
        private double _temperature;
        private double _humidity;
        private double _pressure;

        public WeatherData()
        {
            _observers = new List<ICustomObserver>();
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            };
        }

        public void RegisterObserver(ICustomObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(ICustomObserver o)
        {
            if (_observers.IndexOf(o) >= 0)
                _observers.Remove(o);
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(double temperature, double humidity, double pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}
