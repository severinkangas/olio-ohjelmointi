
// Tehdään abstracti luokka, jossa perittävä Draw()-metodi.
public abstract class DrawObject
{
    public abstract void Draw();
}

// Box-luokka, periytyy DrawObject-luokasta.
public class Box : DrawObject
{

    // Draw-metodi, override jotta ylikirjoittaa pääluokan metodin.
    public override void Draw()
    {
        Console.WriteLine("Box-luokan draw-metodi:");
        Console.WriteLine("*******");
        Console.WriteLine("*     *");
        Console.WriteLine("*******");
    }
}

// Triangle-luokka, periytyy DrawObject-luokasta.
public class Triangle : DrawObject
{

    // Draw-metodi, override jotta ylikirjoittaa pääluokan metodin.
    public override void Draw()
    {
        Console.WriteLine("Triangle-luokan draw-metodi.");
        Console.WriteLine("     *     ");
        Console.WriteLine("    * *    ");
        Console.WriteLine("  * * * *  ");
        Console.WriteLine("* * * * * *");
    }
}