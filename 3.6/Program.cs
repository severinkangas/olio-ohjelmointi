using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace bonus36;
class Program
{
    static void Main(string[] args)
    {

        // Tehdään dictionary, jossa key presidentin nimi, value syntymävuosi
        Dictionary<string, int> presidents = new Dictionary<string, int>();
        presidents.Add("Rutherford B. Hayes", 1822);
        presidents.Add("James A. Garfield", 1831);
        presidents.Add("Chester A. Arthur", 1829);
        presidents.Add("Grover Cleveland", 1837);
        presidents.Add("Benjamin Harrison", 1833);
        presidents.Add("William McKinley", 1843);
        presidents.Add("Theodore Roosevelt", 1858);

        // Muuttujat, joilla saadaan laskettua jos presidentti on syntynyt 1830-1839 välissä
        int start1830 = 1830;
        int end1839 = 1839;

        // Etsitään dictionaryn valueista, mitkä ovat välillä 1830-1839, tallennetaan keyt ja valuet uuteen dictionaryyn
        var presidentsBetween1830_1839 = presidents.Where(kv => kv.Value >= start1830 && kv.Value <= end1839).ToDictionary(kv => kv.Key, kv => kv.Value);

        // Lasketaan avainten määrä, tulostetaan vastaus
        int presidentCount = presidentsBetween1830_1839.Count();
        Console.WriteLine($"1830-luvulla syntyneitä presidenttejä: {presidentCount} kpl");

        // Muuttujat 1820-luvulla syntyneille
        int start1820 = 1820;
        int end1829 = 1829;

        // Etsitään 1820-luvulla syntyneet, tallennetaan pelkät nimet listaan. 
        var presidentsBetween1820_1829 = presidents.Where(kv => kv.Value >= start1820 && kv.Value <= end1829).Select(kv => kv.Key).ToList();

        // Tulostetaan nimet yhdelle riville
        Console.WriteLine(string.Format("1820-luvulla syntyneet presidentit: {0}. ", string.Join(", ", presidentsBetween1820_1829)));

        // Haetaan dictionaryn kaikki valuet listaan
        var presidentsDateOfBirth = presidents.Select(kv => kv.Value).ToList();

        // Lasketaan listan keskiarvo
        var presidentsDateOfBirthAvg = presidentsDateOfBirth.Average();

        // Tulostetaan listan keskiarvo, pyöristetään kokonaislukuihin
        Console.WriteLine($"Presidenttien keskimääräinen syntymävuosi: {Math.Round(presidentsDateOfBirthAvg, 0)}");
    }
}
