namespace Observer.WeatherStation.Abstractions
{
    public interface IObserver
    {
        void Update(IObservable observable);
    }
}
