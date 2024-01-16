namespace tehtava23;
class Program
{
    static void Main(string[] args)
    {
        // Kysytään käyttäjältä numerot, muutetaan Convertilla suoraan doubleksi
        Console.WriteLine("Anna luku yksi (desimaalimerkkinä pilkku):");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Anna luku kaksi (desimaalimerkkinä pilkku):");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Laskutoimitukset, pyöristetään Math.Roundilla suoraan kahteen desimaaliin.
        Console.WriteLine($"Lukujen {number1} ja {number2} laskuoperaatiot");
        Console.WriteLine($"Jakolasku: {Math.Round(number1/number2, 2)}");
        Console.WriteLine($"Kertolasku: {Math.Round(number1*number2, 2)}");
        Console.WriteLine($"Vähennyslasku: {Math.Round(number1-number2, 2)}");
        Console.WriteLine($"Yhteenlasku: {Math.Round(number1+number2, 2)}");
    }
}
