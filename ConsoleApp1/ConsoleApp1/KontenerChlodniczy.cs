namespace ConsoleApp1;

public class KontenerChlodniczy : Contener
{
    private string NumerSeryjny { get; set; } = "KON-C-";
    public Products Product { get; set; }
    public double Temperature { get; set; }

    private Dictionary<Products, double> Products = new Dictionary<Products, double>()
    {
        { ConsoleApp1.Products.Banana, 13.3 },
        { ConsoleApp1.Products.Chocolate, 18.0 },
        { ConsoleApp1.Products.Fish, 2.0 },
        { ConsoleApp1.Products.Meat, -15.00 },
        { ConsoleApp1.Products.Ice_Cream, -18.0 },
        { ConsoleApp1.Products.Frozen_Pizza, -30 },
        { ConsoleApp1.Products.Cheese, 7.2 },
        { ConsoleApp1.Products.Sausage, 5.0 },
        { ConsoleApp1.Products.Butter, 20.5 },
        { ConsoleApp1.Products.Eggs, 19.0 }
    };

    public KontenerChlodniczy(int wysokosc, double waga, int glebokosc, double maxLadownosc, double temperature,
        Products product) : base(wysokosc, waga, glebokosc, maxLadownosc)
    {
        NumerSeryjny += Contener.NextNumerSeryjny;
        Temperature = temperature;
        Product = product;
    }

    public void ZaladujKontener(double masaLadunku, Products product = ConsoleApp1.Products.Default)
    {
        if (product != Product)
        {
            Console.WriteLine("Container is for " + Product + " you can't put in diffrent product!");
            return;
        }
        
        if (Temperature < Products[product])
        {
                Console.WriteLine("Temperature in this container is to low for this kind of product!");
                return;
        }

        if ( (masaLadunku + MasaLadunku) > MaxLadownosc )
        { 
            throw new OverfillException("You try to overfill container " + NumerSeryjny + " !");
        }
        MasaLadunku += masaLadunku;
        Console.WriteLine("Kontener załadowany ładunkiem o masie: "+ masaLadunku);
    }

    public override void getInfo()
    {
        Console.WriteLine("Kontener o numerze: " + NumerSeryjny + " przeznaczony na " + Product + "\n" +
                          "o aktualnej masie: " + (Waga + MasaLadunku) +" kg"+ "\n"+ "oraz temperaturze przechowywania " +
                          Temperature + "\u00b0C"+"\n" );
    }
}