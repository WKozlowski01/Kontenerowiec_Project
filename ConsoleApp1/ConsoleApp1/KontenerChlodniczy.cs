namespace ConsoleApp1;

public class KontenerChlodniczy : Contener
{ 
    public string NumerSeryjny { get; set; } = "KON-C-";
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
    
    public KontenerChlodniczy(int wysokosc, float waga, float glebokosc,double maxLadownosc,double temperature,Products product) : base(wysokosc, waga, glebokosc,maxLadownosc)
    {
        NumerSeryjny += Contener.NextNumerSeryjny;
        Temperature = temperature;
        Product = product;
    }
    public override void ZaladujKontener(int masaLadunku)
    {
        Console.WriteLine("You Need to give product category ");
    }

    public void ZaladujKontener(int masaLadunku,Products product)
    {
        if (product != Product)
        {
            Console.WriteLine("Container is for "+Product +" you can't put in diffrent product!");
            
        }
        else
        {
            if (Temperature < Products[product])
            {
                Console.WriteLine("Temperature in this container is to low for this kind of product!");
            }
            else
            {
                Product = product;
            
                if (masaLadunku > (MaxLadownosc - MasaLadunku))
                {
                    throw new OverflowException("You try to overfill container "+ NumerSeryjny+ " !");
            
                }else
                {
                    MasaLadunku = masaLadunku;
                }
            }
        }
    }
    
}