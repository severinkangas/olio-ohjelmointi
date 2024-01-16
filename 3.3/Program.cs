namespace tehtava33;
class Program
{
    static void Main(string[] args)
    {
        // Tehdään uusi lista students
        var students = new List<String>();

        // for-loop, jossa kysytään 5 kertaa käyttäjältä oppilaan nimi joka tallennetaan listaan
        for (int i = 0; i < 5; i++) 
        {
            Console.WriteLine("Anna oppilaan nimi:");
            string ?student = Console.ReadLine();
            students.Add(student);
        }

        // Tulostetaan oppilaiden nimet käymällä lista foreachilla läpi
        Console.WriteLine("Tallennetut nimet:");
        foreach (string studentName in students)
        {
            Console.WriteLine(studentName);
        }
    }
}
