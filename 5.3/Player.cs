using System.Xml.Serialization;

public class Player
{
    // luokat pisteille ja valinnoille
    private int Points{get; set;}
    private int Choice{get; set;}

    // metodi valintojen tallentamiseen
    public void setChoice(int newChoice)
    {
        Choice = newChoice;
    }

    // metodi valintojen lukemiseen muuttujasta
    public int readChoice()
    {
        return Choice;
    }

    // metodi pisteiden asettamiseen
    public void setPoints()
    {
        Points++;
    }

    // metodi pisteiden lukemiseen
    public int readPoints()
    {
        return Points;
    }
}

// Human-luokka, periytynyt Player-luokasta. Nimi private stringinä, mahdollisuus lisätä nimi ja lukea nimi
public class Human : Player
{
    private String Name{get; set;}
    public void setName(String newName)
    {
        Name = newName;
    }
    public String readName()
    {
        return Name;
    }

}

// Computer-luokka, periytynyt Player-luokasta. Metodi random-luvun arvontaan.
public class Computer : Player
{
    public void computerChoice()
    {
        Random r = new Random();
        int choice = r.Next(1, 4);
        setChoice(choice);
    }
    
}
