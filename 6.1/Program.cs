using System.ComponentModel;

namespace tehtava61;
class Program
{
    static void Main(string[] args)
    {

        // alustetaan oliot
        Product cellphone = new Product();
        Product book1 = new Book();
        Product food1 = new Food();
        Product book2 = new Book();
        Product food2 = new Food();
        Product television = new Product();
        Product book3 = new Book();
        Product food3 = new Food();
        Product computer = new Product();
        Product mouse = new Product();
        Customer customer = new Customer();
        TaxCalculator tax = new TaxCalculator();
        TaxCalculator bookTax = new BookTaxCalculator();
        TaxCalculator foodTax = new FoodTaxCalculator();

        // boolean ohjelman ajamiseen kunnes käyttäjä lopettaa
        bool running = true;

        // lisätään oliot
        cellphone.Name = "Nokia";
        cellphone.Price = 799;

        book1.Name = "Täällä Pohjantähden Alla";
        book1.Price = 49.90;

        food1.Name = "Pizza";
        food1.Price = 11.90;

        book2.Name = "Sinuhe, egyptiläinen";
        book2.Price = 39.90;

        food2.Name = "Hampurilainen";
        food2.Price = 9.90;

        television.Name = "Philips";
        television.Price = 499;

        book3.Name = "Tuntematon Sotilas";
        book3.Price = 19.90;

        food3.Name = "Sushi";
        food3.Price = 14.90;

        computer.Name = "Acer";
        computer.Price = 399.90;

        mouse.Name = "Logitech";
        mouse.Price = 59.90;

        // lista, johon tuotteet tallennetaan
        List<Product> products = new List<Product>();

        // pääohjelma
        while (running)
        {
            Console.WriteLine("Tervetuloa verkkokauppaan!");
            Console.WriteLine();
            Console.WriteLine();

            // tulostetaan käyttäjän ostoskori, näytetään tuotteiden määrä
            Console.WriteLine($"Ostoskorissasi on {customer.showProductCount()} tuotetta.");
            
            // jos tuotteita enemmän kuin 0, tulostetaan tuotteet ja hinnat
            if (customer.showProductCount() > 0)
            {
                Console.WriteLine("Tuotteet:");
                foreach (Product tuote in products)
                {
                    Console.WriteLine($"{tuote.Name}, {tuote.Price}");
                }
                Console.WriteLine("-------------");
                Console.WriteLine($"Yhteissumma: {customer.showSum()} euroa.");
            }

            // käyttäjän valinnat
            Console.WriteLine();
            Console.WriteLine("Valitse tuote:");
            Console.WriteLine("1. Nokia-puhelin, 799 euroa");
            Console.WriteLine("2. Täällä Pohjantähden Alla, 49.90 euroa");
            Console.WriteLine("3. Pizza, 11.90 euroa");
            Console.WriteLine("4. Sinuhe, egyptiläinen, 39.90 euroa");
            Console.WriteLine("5. Hampurilainen, 9.90 euroa");
            Console.WriteLine("6. Philips-TV, 499 euroa");
            Console.WriteLine("7. Tuntematon Sotilas, 19.90 euroa");
            Console.WriteLine("8. Sushi, 14.90 euroa");
            Console.WriteLine("9. Acer-tietokone, 399.90 euroa");
            Console.WriteLine("10. Logitech-hiiri, 59.90 euroa");
            Console.WriteLine();
            Console.WriteLine("0. Lopeta ja tulosta kuitti");
            int userInput = Convert.ToInt16(Console.ReadLine());

            // ehtolauseet käyttäjän valinnoille. Ilmoitetaan tuote joka valittu, lisätään kokonaismäärään, lasketaan verot metodien
            // avulla, lasketaan summa kokonaissummaan, lisätään tuote listaan
            if (userInput == 1)
            {
                Console.WriteLine("Valitsit tuotteen 1. Tuote lisätty ostoskoriin.");
                Console.WriteLine();
                customer.addProductCount();
                tax.calculate(cellphone.Price);
                customer.addToSum(cellphone.Price);
                products.Add(cellphone);
                
            }
            if (userInput == 2)
            {
                Console.WriteLine("Valitsit tuotteen 2. Tuote lisätty ostoskoriin.");
                Console.WriteLine();
                customer.addProductCount();
                bookTax.calculate(book1.Price);
                customer.addToSum(book1.Price);
                products.Add(book1);
                
            }
            if (userInput == 3)
            {
                Console.WriteLine("Valitsit tuotteen 3. Tuote lisätty ostoskoriin.");
                Console.WriteLine();
                customer.addProductCount();
                foodTax.calculate(food1.Price);
                customer.addToSum(food1.Price);
                products.Add(food1);
                
            }
            if (userInput == 4)
            {
                Console.WriteLine("Valitsit tuotteen 4. Tuote lisätty ostoskoriin.");
                Console.WriteLine();
                customer.addProductCount();
                bookTax.calculate(book2.Price);
                customer.addToSum(book2.Price);
                products.Add(book2);
                
            }
            if (userInput == 5)
            {
                Console.WriteLine("Valitsit tuotteen 5. Tuote lisätty ostoskoriin.");
                Console.WriteLine();
                customer.addProductCount();
                foodTax.calculate(food2.Price);
                customer.addToSum(food2.Price);
                products.Add(food2);
                
            }
            if (userInput == 6)
            {
                Console.WriteLine("Valitsit tuotteen 6. Tuote lisätty ostoskoriin.");
                Console.WriteLine();
                customer.addProductCount();
                tax.calculate(television.Price);
                customer.addToSum(television.Price);
                products.Add(television);
                
            }
            if (userInput == 7)
            {
                Console.WriteLine("Valitsit tuotteen 7. Tuote lisätty ostoskoriin.");
                Console.WriteLine();
                customer.addProductCount();
                bookTax.calculate(book3.Price);
                customer.addToSum(book3.Price);
                products.Add(book3);
                
            }
            if (userInput == 8)
            {
                Console.WriteLine("Valitsit tuotteen 8. Tuote lisätty ostoskoriin.");
                Console.WriteLine();
                customer.addProductCount();
                foodTax.calculate(food3.Price);
                customer.addToSum(food3.Price);
                products.Add(food3);
                
            }
            if (userInput == 9)
            {
                Console.WriteLine("Valitsit tuotteen 9. Tuote lisätty ostoskoriin.");
                Console.WriteLine();
                customer.addProductCount();
                tax.calculate(computer.Price);
                customer.addToSum(computer.Price);
                products.Add(computer);
                
            }
            if (userInput == 10)
            {
                Console.WriteLine("Valitsit tuotteen 10. Tuote lisätty ostoskoriin.");
                Console.WriteLine();
                customer.addProductCount();
                tax.calculate(mouse.Price);
                customer.addToSum(mouse.Price);
                products.Add(mouse);
            }

            // kuitin tulostus kun käyttäjä lopettaa ohjelman. listaa tuotteet, näyttää eri veroluokkien summat, lopettaa ohjelman
            if (userInput == 0)
            {
                Console.WriteLine("Lopetit ostot.");
                Console.WriteLine("--------------");
                Console.WriteLine("Kuitti");
                Console.WriteLine();
                foreach (Product tuote in products)
                {
                    Console.WriteLine($"{tuote.Name}, {tuote.Price} euroa");
                }
                Console.WriteLine();
                Console.WriteLine($"Yhteissumma: {customer.showSum()}");
                Console.WriteLine($"Vero 10%: {bookTax.showTaxSum()}");
                Console.WriteLine($"Vero 14%: {foodTax.showTaxSum()}");
                Console.WriteLine($"Vero 24%: {tax.showTaxSum()}");
                running = false;
            }
        }
    }
}
