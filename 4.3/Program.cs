namespace tehtava43;
class Program
{
    static void Main(string[] args)
    {
        // alustetaan olio
        Termostaatti temp = new Termostaatti();

        // määritellään lämpötilat
        temp.CurrentValue = 10.0;
        temp.TargetValue = 20.0;

        // käynnistetään termostaatti
        temp.start();
        
        // lämpötilan nosto
        temp.heat();
        temp.heat();
        temp.heat();
        temp.heat();
        temp.heat();

        // lämpötilan lasku
        temp.cool();
    }
}
