namespace ObserverPattern
{
    public interface ICustomObserver
    {
        void Update(double temperature, double humidity, double pressure);
    }
}
