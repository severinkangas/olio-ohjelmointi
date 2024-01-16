
// Tehdään abstraktiluokka Person
public abstract class Person
{

    // Muuttujat nimelle ja iälle.
    public String? Name{get; set;}
    public Int32 Age{get; set;}

    // Abstrakti-metodi move(), joka peritään aliluokissa.
    public abstract void move();
}

// Adult luokka, periytyy Personista.
public class Adult : Person
{

    // Metodi, joka tulostaa nimen, iän ja liikkumismuodon.
    public override void move()
    {
        Console.WriteLine($"Olen {Name} ja ikäni on {Age}.");
        Console.WriteLine("Liikkumismuotoni on käveleminen.");
    }
}

// Baby-luokka, periytyy Personista.
public class Baby : Person
{

    // Metodi, joka tulostaa nimen, iän ja liikkumismuodon.
    public override void move()
    {
        Console.WriteLine($"Olen {Name} ja ikäni on {Age}.");
        Console.WriteLine("Liikkumismuotoni on konttaaminen.");
    }
}