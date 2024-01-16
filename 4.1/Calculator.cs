// Luodaan Calculator-luokka
public class Calculator
{
    // Tehdään muuttujat käyttäjän luvuille
    public double value1;
    public double value2;
    
    // Tehdään metodit laskutoimituksille, palautetaan vastaukset
    public double addition(double value1, double value2)
    {
        return value1+value2;
    }
    public double subtraction(double value1, double value2)
    {
        return value1-value2;
    }
    public double divide(double value1, double value2)
    {
        return value1/value2;
    }
    public double multiply(double value1, double value2)
    {
        return value1*value2;
    }
}
