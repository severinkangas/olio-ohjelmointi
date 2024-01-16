namespace tehtava45;
class Program
{
    static void Main(string[] args)
    {
        Oppilas student1 = new Oppilas();
        Oppilas student2 = new Oppilas();
        Oppilas student3 = new Oppilas();

        student1.Name = "Jaakko Jaakonpoika";
        student1.Address = "Katutie 1";
        student1.ID = "1";
        student1.Email = "jaska@jaakonpoika.com";

        student2.Name = "Pasi Pavunvarsi";
        student2.Address = "Katutie 44";
        student2.ID = "2";
        student2.Email = "pasi@papu.com";

        student3.Name = "Tiina Tiikeri";
        student3.Address = "Polkutie 13";
        student3.ID = "3";
        student3.Email = "tiina@kellogs.com";

        List<Oppilas> students = new List<Oppilas>();

        students.Add(student1);
        students.Add(student2);
        students.Add(student3);

        foreach (Oppilas student in students)
        {
            Console.WriteLine($"Oppilaan ID: {student.ID}");
            Console.WriteLine($"Oppilaan nimi: {student.Name}");
            Console.WriteLine($"Oppilaan osoite: {student.Address}");
            Console.WriteLine($"Oppilaan email: {student.Email}");
            Console.WriteLine();
        }
    }
}
