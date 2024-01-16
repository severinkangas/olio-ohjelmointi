namespace tehtava22;
class Program
{
    static void Main(string[] args)
    {
        // Kysytään opiskelijan pisteet, muutetaan doubleksi, lasketaan montako prosenttia käyttäjän antama
        // luku on maksimipisteistä.
        Console.WriteLine("Anna opiskelijan pisteet:");
        string ?pisteet = Console.ReadLine();
        double i = Int32.Parse(pisteet);
        double numero = i / 81 * 100;

        // Ehtolause, jossa verrataan prosenttimäärää kurssin arvosanoihin.
        if ( i > 81 )
        {
            Console.WriteLine("Opiskelijalla liikaa pisteitä. Kurssin maksimipistemäärä 81.");
        }
        else if ( numero >= 90 ) 
        {
            Console.WriteLine("Opiskelijan arvosana on 5.");
        }
        else if ( numero < 90 && numero >= 80 ) 
        {
            Console.WriteLine("Opiskelijan arvosana on 4.");
        }
        else if ( numero < 80 && numero >= 70 ) 
        {
            Console.WriteLine("Opiskelijan arvosana on 3.");
        }
        else if ( numero < 70 && numero >= 60 ) 
        {
            Console.WriteLine("Opiskelijan arvosana on 2.");
        }
        else if ( numero < 60 && numero >= 50 ) 
        {
            Console.WriteLine("Opiskelijan arvosana on 1.");
        }
        else if ( numero < 50 ) 
        {
            Console.WriteLine("Opiskelijan arvosana on 0.");
        }
    }
}