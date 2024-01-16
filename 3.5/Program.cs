namespace tehtava35;
class Program
{
    static void Main(string[] args)
    {

        // Lista, jossa USAn presidentit
        var presidents = new List<String> {"Theodore,Roosevelt","William,Taft","Woodrow,Wilson","Warren,Harding","Calvin,Coolidge","Herbert,Hoover","Franklin,Roosevelt","Harry,Truman","Dwight,Eisenhower","John,Kennedy","Lyndon,Johnson","Richard,Nixon"};
        
        // Sortataan lista etunimen perusteella
        presidents.Sort();

        // Käydään lista läpi foreachilla
        foreach (var president in presidents)
        {
            Console.WriteLine(president);
        }

    }
}
