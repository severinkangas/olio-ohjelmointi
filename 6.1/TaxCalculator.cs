// TaxCalculator luokka
public class TaxCalculator
{
    // Vero-muuttuja 24% verolle
    private double tax = 0.24;
    // Muuttuja, jossa säilytetään 24%-verotuotteiden veron osuus
    public double taxSum = 0;

    // Metodi veron laskuun, tallentaa verojen määrän muuttujaan
    public virtual void calculate(double sum)
    {
        taxSum += sum * tax;
    }

    // Metodi, joka palauttaa verot 2 desimaalin tarkkuudella
    public virtual double showTaxSum()
    {
        return Math.Round(taxSum, 2);
    }
}

// Ruoanveron laskuri, periytyy edellisestä laskurista
public class FoodTaxCalculator : TaxCalculator
{
    private double tax = 0.14;
    public override void calculate(double sum)
    {
        taxSum += sum * tax;
    }
    public override double showTaxSum()
    {
        return Math.Round(taxSum, 2);
    }
}

// Kirjojen laskuri, periytyy alkuperäisestä laskurista
public class BookTaxCalculator : TaxCalculator
{
    private double tax = 0.10;
    private double bookTaxSum = 0;
    public override void calculate(double sum)
    {
        bookTaxSum += sum * tax;
    }
    public override double showTaxSum()
    {
        return Math.Round(bookTaxSum, 2);
    }
}

// Luokka tuotteille
public class Product
{
    public String? Name{get; set;}
    public double Price{get; set;}
}


// näihin voi lisätä pelkästään tähän luokkaan tarvittavia tietoja, periytyvät product-luokasta
public class Book : Product
{

}
public class Food : Product
{

}

// Luokka asiakkaan tuotteille
public class Customer
{
    // muuttuja, johon tallennetaan asiakkaan valitsemien tuotteiden määrä
    private double productCount = 0;

    // muuttuja, johon tallennetaan tuotteiden yhteissumma
    private double sum = 0;

    // metodi, jossa lasketaan tuotteiden määrä
    public void addProductCount()
    {
        productCount++;
    }

    // metodi, joka palauttaa tuotteiden määrän
    public double showProductCount()
    {
        return productCount;
    }

    // metodi, joka laskee tuotteiden yhteishinnan muuttujaan
    public void addToSum(double productPrice)
    {
        sum += productPrice;
    }

    // metodi, joka laskee palauttaa tuotteiden hinnan, kahden desimaalin tarkkuus
    public double showSum()
    {
        return Math.Round(sum, 2);
    }
}