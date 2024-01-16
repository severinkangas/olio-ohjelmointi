// tehdään yhteinen Person-luokka, josta muut perivät nimen ja iän 
public class Person
{
    public String? Name{get; set;}
    public int Age{get;set;}
}

// Student-luokka, joka periytyy Person-luokasta, lisätään opintosuuntaus
public class Student : Person
{
    public String? StudyProgram{get;set;}

    // ToString, tulostaa terminaaliin nimen, iän ja opintosuuntauksen
    public void ToString()
    {
        Console.WriteLine($"{this.Name} - {this.Age}v - {this.StudyProgram}");
    }
}

// ExchangeStudent-luokka, joka periytyy Student-luokasta
public class ExchangeStudent : Student
{

}

// Teacher-luokka, periytyy Person-luokasta, lisätään palkkatieto
public class Teacher : Person
{
    public double Salary{get; set;}

    // ToString, tulostaa terminaaliin nimen, iän ja palkan
    public void ToString()
    {
        Console.WriteLine($"{this.Name} - {this.Age}v - {this.Salary}");
    }
}