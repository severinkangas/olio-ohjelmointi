namespace tehtava71;
class Program
{
    static void Main(string[] args)
    {

        // Alustetaan oliot
        Adult aikuinen = new Adult();
        Baby vauva = new Baby();

        // Asetetaan Adult-muuttujiin tiedot.
        aikuinen.Name = "Erkki";
        aikuinen.Age = 44;

        // Asetetaan Baby-muuttujiin tiedot.
        vauva.Name = "Taavi";
        vauva.Age = 1;

        // Kutsutaan move()-metodeja.
        aikuinen.move();
        vauva.move();
    }
}
