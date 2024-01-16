namespace tehtava72;
class Program
{
    static void Main(string[] args)
    {

        // Alustetaan oliot.
        Box laatikko = new Box();
        Triangle kolmio = new Triangle();

        // Kutsutaan Draw-metodeja.
        laatikko.Draw();
        kolmio.Draw();
    }
}
