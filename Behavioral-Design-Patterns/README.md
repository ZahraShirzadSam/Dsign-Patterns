# Observer Pattern
The Observer Design Pattern is a behavioral design pattern that defines a one-to-many dependency between objects so that when one object (the subject) changes state, all its dependents (observers) are notified and updated automatically.

# Intent
The Observer pattern is to notify the interested observers about some change occurred. We can add more observers in runtime as well as remove them.

## Components of Observer Design Pattern
<p align="center" width="100%">
    ![OBS](https://github.com/ZaraSam/Dsign-Patterns/assets/136806163/165013da-fa2f-451f-b108-abf45c31ca4c)
</p>

- 
1. Subject: 
2. Observer:
3. ConcreteSubject: 
4. ConcreteObserver:

## Structure
For a weather monitoring system, various displays (like a current conditions display or a forecast display) can act as observers to a weather data subject. When the weather data changes, all the displays update their information.


## UML Class Diagram
![ObserverPattern](https://github.com/ZaraSam/Dsign-Patterns/assets/136806163/c45cfc47-d3ad-4945-b953-40c40c9b14e5)


## UML Sequence Diagram
![Se](https://github.com/ZaraSam/Dsign-Patterns/assets/136806163/938a9c29-a179-4f1f-bd9f-f09905f668a9)

## References
- eBook: Dive Into Design Patterns.
- webSite: https://refactoring.guru
