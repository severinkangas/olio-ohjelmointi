namespace tehtava53;
class Program
{
    static void Main(string[] args)
    {
        // alustetaan oliot
        Computer computer = new Computer();
        Human player = new Human();

        // kysytään käyttäjältä nimi, haetaan setName-metodi ja tallennetaan nimi
        Console.WriteLine("Anna nimesi:");
        player.setName(Console.ReadLine());
        
    // while-loop pyörittämään peliä kunnes jompikumpi saa 3
    while (player.readPoints() < 3 && computer.readPoints() < 3)
    {
        // kysytään käyttäjältä valinta, arvotaan tietokoneen valinta
        Console.WriteLine("Minkä valiset? 1) kivi 2) sakset 3) paperi");
        player.setChoice(Convert.ToInt32(Console.ReadLine()));
        computer.computerChoice();

            // ehtolauseet peleihin, voitosta lisätään piste, tulostetaan tilanne joka välissä
            if (player.readChoice() == 1 && computer.readChoice() == 1)
            {
                Console.WriteLine("Tasapeli!");
                Console.WriteLine($"Pistetilanne: {player.readName()} {player.readPoints()} - {computer.readPoints()} Tietokone");
            }
            if (player.readChoice() == 2 && computer.readChoice() == 2)
            {
                Console.WriteLine("Tasapeli!");
                Console.WriteLine($"Pistetilanne: {player.readName()} {player.readPoints()} - {computer.readPoints()} Tietokone");
            }
            if (player.readChoice() == 3 && computer.readChoice() == 3)
            {
                Console.WriteLine("Tasapeli!");
                Console.WriteLine($"Pistetilanne: {player.readName()} {player.readPoints()} - {computer.readPoints()} Tietokone");
            }
            if (player.readChoice() == 2 && computer.readChoice() == 1)
            {
                Console.WriteLine("Voitit!");
                player.setPoints();
                Console.WriteLine($"Pistetilanne: {player.readName()} {player.readPoints()} - {computer.readPoints()} Tietokone");
            }
            if (player.readChoice() == 3 && computer.readChoice() == 2)
            {
                Console.WriteLine("Voitit!");
                player.setPoints();
                Console.WriteLine($"Pistetilanne: {player.readName()} {player.readPoints()} - {computer.readPoints()} Tietokone");
            }        
            if (player.readChoice() == 1 && computer.readChoice() == 3)
            {
                Console.WriteLine("Voitit!");
                player.setPoints();
                Console.WriteLine($"Pistetilanne: {player.readName()} {player.readPoints()} - {computer.readPoints()} Tietokone");
            }
            if (computer.readChoice() == 1 && player.readChoice() == 3)
            {
                Console.WriteLine("Hävisit!");
                computer.setPoints();
                Console.WriteLine($"Pistetilanne: {player.readName()} {player.readPoints()} - {computer.readPoints()} Tietokone");
            }
            if (computer.readChoice() == 2 && player.readChoice() == 1)
            {
                Console.WriteLine("Hävisit!");
                computer.setPoints();
                Console.WriteLine($"Pistetilanne: {player.readName()} {player.readPoints()} - {computer.readPoints()} Tietokone");
            }
            if (computer.readChoice() == 3 && player.readChoice() == 2)
            {
                Console.WriteLine("Hävisit!");
                computer.setPoints();
                Console.WriteLine($"Pistetilanne: {player.readName()} {player.readPoints()} - {computer.readPoints()} Tietokone");
            }

        // ehtolauseet, kun peli loppuu
        if (player.readPoints() == 3)
        {
            Console.WriteLine("Onneksi olkoon, voitit pelin!");
        }
        if (computer.readPoints() == 3)
        {
            Console.WriteLine("Voe rähmä, hävisit pelin.");
        }
    }
    }
}
