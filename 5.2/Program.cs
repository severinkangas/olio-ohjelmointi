namespace tehtava52;
class Program
{
    static void Main(string[] args)
    {
        // Alustetaan oliot
        Student student = new Student();
        Teacher teacher = new Teacher();
        ExchangeStudent exchangeStudent = new ExchangeStudent();

        // Lisätään opiskelijan tiedot
        student.Name = "Olivia Opiskelija";
        student.Age = 25;
        student.StudyProgram = "TVT";

        // Lisätään vaihto-opiskelijan tiedot
        exchangeStudent.Name = "Sally Student";
        exchangeStudent.Age = 32;
        exchangeStudent.StudyProgram = "Maanmittaus";

        // Lisätään opettajan tiedot
        teacher.Name = "Matti Meikäläinen";
        teacher.Age = 55;
        teacher.Salary = 4300;

        // ToString-metodien kutsut
        student.ToString();
        exchangeStudent.ToString();
        teacher.ToString();
    }
}
