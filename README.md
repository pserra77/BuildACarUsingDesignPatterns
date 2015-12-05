# [Build A Car And Drive It Too Using Design Patterns] (http://prezi.com/hgi7-nayhmme/?utm_campaign=share&utm_medium=copy)


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
 

Build Specialized cars using "Abtract Factory" to create a family of products (Powertrain, Interior, Body) for each car.

Accessorize each car by dynamically adding operations using "Decorator"

Define steps to Drive a car using "Template Method" but let subclasses define the implementation of these steps.

To rent the car, we need to verify the credability of the customer. Verify customer based on the state that he wants to drive. Use "Strategy pattern" to dynamically decide the implementation.
