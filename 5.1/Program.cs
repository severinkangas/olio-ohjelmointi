namespace tehtava51;
class Program
{
    static void Main(string[] args)
    {

        // alustetaan uusi Car-luokka
        Car car = new Car();

        // käynnistetään auto
        car.startCar();

        // kiihdytetään, parametrina tavoitenopeus
        car.accelerate(300);

        // jarrutetaan
        car.brake();

        // sammutetaan moottori
        car.stopEngine();

        // lukitaan ovet
        car.lockDoor(true);

    }
}
