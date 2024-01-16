using System.IO.Compression;

public class Car
{

    // muuttujat
    private int fuel = 100;
    private bool engineRunning = false;
    private bool doors = false;
    private int currentSpeed = 0;
    private int maxSpeed = 100;
    private bool lockDoors = false;


    // kiihdytys-metodi joka ottaa speed-parametrin
    public void accelerate(int speed)
    {
        // muutetaan maxSpeediksi speed-parametrista tullut speed
        maxSpeed = speed;

        // katotaan onko moottori käynnissä, onko polttoainetta ja että ovet ovat kiinni
        if (engineStarted() && checkFuel() && !doorsOpen())
        {
            while (currentSpeed < maxSpeed)
            {
                currentSpeed += 5;
                Console.WriteLine(currentSpeed);
            }
        }
    }

    // käynnistysmetodi, muutetaan engineRunning-boolean trueksi
    public void startCar()
    {
        engineRunning = true;
        Console.WriteLine("Moottori käynnistetty.");
    }

    // jarrutetaan kunnes currentSpeed on 0
    public void brake()
    {
        if (engineStarted())
        {
            while (currentSpeed != 0)
            {
                currentSpeed -= 5;
                Console.WriteLine(currentSpeed);
            }
        }
    }

    // sammutetaan moottori muuttamalla engineRunning-boolean
    public void stopEngine()
    {
        engineRunning = false;
        Console.WriteLine("Moottori sammutettu.");
    }

    // Ovien lukitus, oottaa parametrina true tai false
    public void lockDoor(bool lockDoor)
    {
        lockDoors = lockDoor;
        if (lockDoors == true)
        {
            Console.WriteLine("Ovet lukittu.");
        }
        else
        {
            Console.WriteLine("Lukitus avattu.");
        }
    }

    // tarkistetaan polttoaine, jos yli 0 palauttaa true
    private bool checkFuel()
    {
        if (fuel > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // tarkistus, onko moottori käynnissä
    private bool engineStarted()
    {
        if (engineRunning == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // tarkistus, onko ovet auki
    private bool doorsOpen()
    {
        if (doors == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}