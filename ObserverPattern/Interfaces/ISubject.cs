namespace ObserverPattern
{
    public interface ISubject
    {
        void RegisterObserver(ICustomObserver o);
        void RemoveObserver(ICustomObserver o);
        void NotifyObservers();

    }
}
