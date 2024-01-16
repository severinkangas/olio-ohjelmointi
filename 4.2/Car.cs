public class Car
{
    public String? Brand{get; set;}
    public String? Model{get; set;}
    public String? Color{get; set;}
    public String? Engine{get; set;}
    public int currentSpeed;
    bool isStarted = false;
    
    public void startCar()
    {
        isStarted = true;
        Console.WriteLine("Auto käynnistetty.");
    }
    public int accelerateCar()
    {
        currentSpeed = currentSpeed+5;
        return currentSpeed;
    }
    public int decelerateCar()
    {
        currentSpeed = currentSpeed-5;
        return currentSpeed;
    }

}