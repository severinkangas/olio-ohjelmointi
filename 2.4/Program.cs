namespace tehtava24;
class Program
{
    static void Main(string[] args)
    {
        // Kysytään minuutit, muutetaan kokonaisluvuksi.
        Console.WriteLine("Anna kokonaisaika minuutteina:");
        int minutes = Convert.ToInt32(Console.ReadLine());

        // Lasketaan montako päivää minuuteista saa, jäljelle jääneistä lasketaan tunnit, jäljelle jääneistä
        // lasketaan minuutit.
        int days = minutes / 1440;
        int minutesLeft = minutes - days * 1440;
        int hours = minutesLeft / 60;
        int minutesLeft2 = minutesLeft - hours * 60;
        Console.WriteLine($"{minutes} minuuttia on {days} päivää, {hours} tuntia, {minutesLeft2} minuuttia.");
    }
}
