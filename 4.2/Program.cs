// luodaan olio ja arvot
Car car = new Car();

car.Brand = "BMW";
car.Model = "M3";
car.Color = "White";
car.Engine = "3.0";

// käynnistetään auto
car.startCar();

// kun auton nopeus on alle 100, kiihdytetään
while(car.currentSpeed < 100)
{
    car.accelerateCar();
    Console.WriteLine(car.currentSpeed);
}

// kun auton nopeus on yli 0, jarrutetaan
while(car.currentSpeed > 0)
{
    car.decelerateCar();
    Console.WriteLine(car.currentSpeed);
}