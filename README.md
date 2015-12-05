# BuildACarUsingDesignPatterns


Code to build a car, drive it and rent it via Some design patterns - Abstract Factory, Decorator, Template Method, Strategy

For the Presentation:

[Presentation Click Here](http://prezi.com/hgi7-nayhmme/?utm_campaign=share&utm_medium=copy)

# Build a car #
---
![Car Parts](/Carparts.jpg "Car Parts")

To start I need a Car Interface

``` csharp
public interface ICar
{
    // This is the car interface
}

```

## Car has parts ##

```
Let's defines some parts
```

+ **Powertrain and chasis**
    * Engine
        - Camshaft
        - Crank case
        - Cylinder head
        - Drive belt
    * Transmission
        - Axel
        - Clutch
        - Gear
    * Breaking System
+ **Body**
    * Doors
        - Outer door
        - Handle
        - Door Control (Manual/Auto)
    * Windows
    * Bonnet
    * Hood
    * Bumper
    * Tyres
+ **Interiors**
    * Seat
    * Central Console
    * Audio/Video Components
 
