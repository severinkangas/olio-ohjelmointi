namespace tehtava62;
class Program
{
    static void Main(string[] args)
    {
        Lotto lotto = new Lotto();   
        Console.WriteLine("Mihin haluat rivit? 1) Lotto 2) Eurojackpot 3) Vikinglotto.");
        int UserChoiceGame = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Montako riviä?");
        int UserChoiceLines = Convert.ToInt16(Console.ReadLine());
        lotto.ChooseGame(UserChoiceGame, UserChoiceLines);
    }
}
