using Observer.WeatherStation.Abstractions;

namespace Observer.WeatherStation
{
    public class WeatherStationObservable : IObservable
    {
        private int _temprature;
        public int Temprature => _temprature;

        private readonly List<IObserver> observers;

        public WeatherStationObservable()
        {
            observers = new List<IObserver>();
        }
        public void Add(IObserver observer) => observers.Add(observer);
        public void Remove(IObserver observer) => observers.Remove(observer);
        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }

        public void SetTemprature(int temprature)
        {
            _temprature = temprature;
            Notify();
        }
    }
}
