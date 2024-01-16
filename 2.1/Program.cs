namespace tehtava21;
class Program
{
    static void Main(string[] args)
    {
        // Kysytään käyttäjältä numero 1-10 väliltä, muutetaan numero integeriksi muuttujaan i
        Console.WriteLine("Anna numero 1-10:");
        string ?numero = Console.ReadLine();
        int i = Int32.Parse(numero);
        string[] luku = {"yksi", "kaksi", "kolme", "neljä", "viisi", "kuusi", "seitsemän", "kahdeksan", "yhdeksän", "kymmenen"};

        // Ehtolause jos 1 <= i <= 10, tulostaa numeron. Muuten tulostaa "väärä numero".
        if ( 1 <= i && i <= 10 )
        {
            Console.WriteLine($"Annoit numeron {luku[i-1]}");
        }
        else
        {
            Console.WriteLine("Väärä numero.");
        }
    }
}
