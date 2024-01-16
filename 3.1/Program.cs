namespace tehtava31;
class Program
{
    static void Main(string[] args)
    {
        // For-silmukka, joka luettelee 1-25 allekkain
        Console.WriteLine("For-silmukka:");
        for (int i = 1; i < 26; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("");

        // While-silmukka, joka luettelee 1-25 allekkain
        Console.WriteLine("While-silmukka:");
        int whileLoop = 1;
        while (whileLoop < 26)
        {
            Console.WriteLine(whileLoop);
            whileLoop++;
        }

        // Tyhjä muuttuja, johon lisätään joka kierroksella kierroksen "luku"
        int yhteenlasku = 0;
        for (int laskuToimitus = 0; laskuToimitus < 26; laskuToimitus++)
        {
            yhteenlasku = yhteenlasku + laskuToimitus;
        }

        // Yhteenlasku ja keskiarvo
        Console.WriteLine($"Yhteenlasku on: {yhteenlasku}");
        Console.WriteLine($"Keskiarvo on: {yhteenlasku / 25}");
    }
}
