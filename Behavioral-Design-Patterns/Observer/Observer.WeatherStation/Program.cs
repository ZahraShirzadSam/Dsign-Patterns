using Observer.WeatherStation;

var weatherStation = new WeatherStationObservable();

weatherStation.Add(new Kiosk("8.7.5.3"));
weatherStation.Add(new Kiosk("22.11.22.33"));
weatherStation.Add(new TVRoom());



weatherStation.SetTemprature(10);

weatherStation.Add(new WallTV());

weatherStation.SetTemprature(13);