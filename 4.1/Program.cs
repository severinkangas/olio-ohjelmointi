try{
    // Luodaan calc olio
    Calculator calc = new Calculator();

    // Kysytään käyttäjältä 2 lukua, muutetaan suoraan doubleiksi
    Console.WriteLine("Anna 1. luku:");
    calc.value1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Anna 2. luku:");
    calc.value2 = Convert.ToDouble(Console.ReadLine());

    // Kysytään käyttäjältä laskutoimitus
    Console.WriteLine("Valitse laskutoimitus:");
    Console.WriteLine("1) -");
    Console.WriteLine("2) +");
    Console.WriteLine("3) *");
    Console.WriteLine("4) /");
    string ?choice = Console.ReadLine();

    // If-lauseet, jotka kutsuvat metodeja
    if(choice == "1"){
        double result = calc.subtraction(calc.value1, calc.value2);
        Console.WriteLine($"Laskutoimituksen tulos: {result}");
    }
    else if(choice == "2"){
        double result = calc.addition(calc.value1, calc.value2);
        Console.WriteLine($"Laskutoimituksen tulos: {result}");
    }
    else if(choice == "3"){
        double result = calc.multiply(calc.value1, calc.value2);
        Console.WriteLine($"Laskutoimituksen tulos: {result}");
    }       
    else if(choice == "4"){
        double result = calc.divide(calc.value1, calc.value2);
        Console.WriteLine($"Laskutoimituksen tulos: {result}");
    }

}catch(System.Exception e)
{
    Console.WriteLine($"Virhe! {e.GetType()} - {e.Message}");
}