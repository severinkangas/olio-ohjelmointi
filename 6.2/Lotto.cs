using System.Globalization;

public class Lotto
{ 

    // Listat lottonumeroille ja lisänumeroille.
    private List<int> _lottoNumbers = new List<int>();
    private List<int> _extraNumbers = new List<int>();
    
    // Muuttujat lottonumeroille.
    private int _lottoNumber;
    private int _lottoExtraNumber;

    // Metodi, joka arpoo numerot. Ottaa parametreina numeroiden määrän (numbers), lisänumeroiden määrän (extraNumber),
    // isoimman arvottavan numeron (numberMax), isoimman lisänumeron (extraNumberMax)
    private void DrawNumbers(int numbers, int extraNumber, int numberMax, int extraNumberMax)
    {

        // Arpoo tietyn verran numeroita (numbers).
        for (int i = 0; i < numbers; i++)
        {
            var rand = new Random();
            do 
            {
                // Tallentaa arvotut numerot muuttujaan
                _lottoNumber = rand.Next(1, numberMax + 1);
            } 
                //  Tarkistaa, että listassa ei ole valmiiksi arvottua numeroa, jos ei niin lisää numeron listaan
            while (_lottoNumbers.Contains(_lottoNumber));
                _lottoNumbers.Add(_lottoNumber);                
        }

        // Arpoo lisänumerot
        for (int i = 0; i < extraNumber; i++)
        {
            var rand = new Random();
            do 
            {
                _lottoExtraNumber = rand.Next(1, extraNumberMax + 1);
            } 
            while (_extraNumbers.Contains(_lottoExtraNumber));
                _extraNumbers.Add(_lottoExtraNumber);                
        }   
            // Järjestää numerot pienimmästä suurimpaan
            _lottoNumbers.Sort();
            _extraNumbers.Sort();
    }

    // Metodi käyttäjän peli- ja rivivalinnoille.
    public void ChooseGame(int userChoiceGame, int userChoiceLines)
    {
        if (userChoiceGame == 1)
        {
            PlayLotto(userChoiceLines);
        }
        if (userChoiceGame == 2)
        {
            PlayEurojackpot(userChoiceLines);
        }
        if (userChoiceGame == 3)
        {
            PlayVikingLotto(userChoiceLines);
        }
    }

    // Metodi loton pelaamiseen, ottaa parametrina montako riviä käyttäjä haluaa.
    private void PlayLotto(int howManyLines)
    {
        for (int i = 0; i < howManyLines; i++)
        {
            // Hakee loopissa DrawNumbers-metodia parametreilla, tulostaa luvut samalle riville.
            DrawNumbers(7, 0, 40, 0);
            Console.WriteLine(string.Format("Lottonumerosi ovat: {0}.", string.Join(", ", _lottoNumbers)));

            // Tyhjentää listan seuraavaa riviä varten.
            _lottoNumbers.Clear();
        }
    }

    // Metodi eurojackpotille
    private void PlayEurojackpot(int howManyLines)
    {
        for (int i = 0; i < howManyLines; i++)
        {
            DrawNumbers(5, 2, 50, 12);
            Console.Write(string.Format("Eurojackpot-numerosi ovat: {0}.", string.Join(", ", _lottoNumbers)));
            Console.WriteLine(string.Format(" Tähtinumerot ovat: {0}.", string.Join(", ", _extraNumbers)));
            _lottoNumbers.Clear();
            _extraNumbers.Clear();
        }
    }

    // Metodi vikinglotolle.
    private void PlayVikingLotto(int howManyLines)
    {
        for (int i = 0; i < howManyLines; i++)
        {
            DrawNumbers(6, 1, 48, 5);
            Console.Write(string.Format("Eurojackpot-numerosi ovat: {0}.", string.Join(", ", _lottoNumbers)));
            Console.WriteLine(string.Format(" Vikingnumero on: {0}.", string.Join(", ", _extraNumbers)));
            _lottoNumbers.Clear();
            _extraNumbers.Clear();
        }
    }
}