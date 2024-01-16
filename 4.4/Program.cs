namespace tehtava44;
class Program
{
    static void Main(string[] args)
    {
        // alustetaan olio
        Termostaatti temp = new Termostaatti();

        // käynnistetään termostaatti
        temp.start();

        // kysytään käyttäjältä tavoitelämpötila, katsotaan antaako käyttäjä numeron
        Console.WriteLine($"Nykyinen lämpötila: {temp.CurrentValue}. Anna tavoite lämpötila:");

        string userInput = Console.ReadLine();
        if (int.TryParse(userInput, out int number))
        {
            temp.TargetValue = number;
        }
        else
        {
            Console.WriteLine("Anna lämpötila numeroina.");
        }


        // loopataan temp.heat() niin kauan kunnes tavoitelämpötila saavutettu
        while (temp.TargetValue > temp.CurrentValue)
        {
            temp.heat();
        }

        // loopataan temp.cool() niin kauan kunnes tavoitelämpötila saavutettu
        while (temp.TargetValue < temp.CurrentValue)
        {
            temp.cool();
        }

        // tulostetaan lämpötila
        Console.WriteLine($"Lämpötila: {temp.CurrentValue}");
    }
}
