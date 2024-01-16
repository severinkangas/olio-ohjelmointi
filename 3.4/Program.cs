using System.Globalization;

namespace tehtava34;
class Program
{
    static void Main(string[] args)
    {
        // Tehdään kaksi listaa
        var list1 = new List<int>{1, 3, 5, 7, 9, 11};
        var list2 = new List<int>{2, 6, 8, 10, 12};

        // Yhdistetään listat, sortataan
        var list1And2 = list1.Concat(list2).ToList();
        list1And2.Sort();

        // Tulostetaan lista yhdelle riville
        Console.WriteLine("Luvut suuruusjärjestyksessä: " + string.Join(", ", list1And2));
    }
}
