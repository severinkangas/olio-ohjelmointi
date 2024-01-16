public class Termostaatti
{
    // tehdään muuttujat päälleololle, tavoitelämpötilalle ja nykyiselle lämpötilalle
    bool isStarted = false;
    public Double TargetValue{get; set;}

    public Double CurrentValue{get; set;}

    // metodi, jossa termostaatti käynnistetään
    public void start()
    {
        isStarted = true;
    }

    // metodi lämpötilan nostoon
    public void heat()
    {
        CurrentValue++;
    }

    // metodi lämpötilan laskemiseen
    public void cool()
    {
        CurrentValue--;
    }
}