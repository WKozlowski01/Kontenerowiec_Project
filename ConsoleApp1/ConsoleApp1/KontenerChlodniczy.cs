namespace ConsoleApp1;

public class KontenerChlodniczy : Contener
{
    
    
    public KontenerChlodniczy(int masa, int wysokosc, float waga, float glebokosc) : base(masa, wysokosc, waga, glebokosc)
    {
        NumerSeryjny += Contener.NextNumerSeryjny;
    }

    public string NumerSeryjny { get; set; } = "KON-C-";
}