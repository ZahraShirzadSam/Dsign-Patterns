# Observer Pattern ![observer-mini](https://github.com/ZaraSam/Dsign-Patterns/assets/136806163/2bb3fc28-2237-429d-8824-c32bd1cb6a9b)

The Observer Design Pattern is a behavioral design pattern that defines a one-to-many dependency between objects so that when one object (the subject) changes state, all its dependents (observers) are notified and updated automatically.

# Intent
The Observer pattern is to notify the interested observers about some change occurred. We can add more observers in runtime as well as remove them.

# Structure
For a weather monitoring system, various displays (like a current conditions display or a forecast display) can act as observers to a weather data subject. When the weather data changes, all the displays update their information.

![OBS](https://github.com/ZaraSam/Dsign-Patterns/assets/136806163/51b21bf0-8d1b-4cf7-be41-f84eeac686cb)

### 1. Subject: 
- The “Subject" interface outlines the operations a subject (like “WeatherStation") should support.
- "addObserver" and “removeObserver" are for managing the list of observers.
- "notifyObservers" is for informing observers about changes.
  
### 2. Observer:
- The “Observer" interface defines a contract for objects that want to be notified about changes in the subject (“WeatherStation" in this case).
- It includes a method “update" that concrete observers must implement to receive and handle updates.
  
### 3. ConcreteSubject: 
- "WeatherStation" is the concrete subject implementing the “Subject" interface.
- It maintains a list of observers (“observers") and provides methods to manage this list.
- "notifyObservers" iterates through the observers and calls their “update" method, passing the current weather.
- "setWeather" method updates the weather and notifies observers of the change.

### 4. ConcreteObserver:
- "TvRoom,WallTV" is a concrete observer implementing the “Observer" interface.
- It has a private field weather to store the latest weather.
- The “update" method sets the new weather and calls the “display" method.
- "display" prints the updated weather to the console.



## UML Class Diagram
![ObserverPattern](https://github.com/ZaraSam/Dsign-Patterns/assets/136806163/c45cfc47-d3ad-4945-b953-40c40c9b14e5)


## UML Sequence Diagram
![Se](https://github.com/ZaraSam/Dsign-Patterns/assets/136806163/938a9c29-a179-4f1f-bd9f-f09905f668a9)

## References
- eBook: Dive Into Design Patterns.
- webSite: https://refactoring.guru
