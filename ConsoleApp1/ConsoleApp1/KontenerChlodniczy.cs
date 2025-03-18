namespace ConsoleApp1;

public class KontenerChlodniczy : Contener
{
    
    
    public KontenerChlodniczy(int masa, int wysokosc, float waga, float glebokosc,double maxLadownosc) : base(masa, wysokosc, waga, glebokosc,maxLadownosc)
    {
        NumerSeryjny += Contener.NextNumerSeryjny;
    }

    public string NumerSeryjny { get; set; } = "KON-C-";
    
}