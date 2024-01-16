using System.Runtime.InteropServices;

namespace tehtava25;
class Program
{
    static void Main(string[] args)
    {
        // tehdään muuttuja palkalle, johon lisätään aina forloopissa kysytty palkka
        // tehdään muuttuja kuukaudelle, johon lisätään aina 1.
        double kokonaispalkka = 0;
        int kuukausi = 1;

        // for-loop
        for ( int i = 0; i < 12; i++)
        {
            Console.WriteLine($"Anna {kuukausi}. kuukauden palkka:");
            kokonaispalkka += Convert.ToDouble(Console.ReadLine());
            kuukausi += 1;
        }

        // tulostus, lasketaan käyttäjän keskipalkka kahden desimaalin tarkkuudella
        Console.WriteLine($"Käyttäjän kokonaispalkka: {kokonaispalkka}");
        Console.WriteLine($"Käyttäjän keskipalkka: {Math.Round(kokonaispalkka/12, 2)}");
    }
}
