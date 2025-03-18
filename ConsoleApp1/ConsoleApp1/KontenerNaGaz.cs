namespace ConsoleApp1;

public class KontenerNaGaz : Contener
{
    public KontenerNaGaz(int masa, int wysokosc, float waga, float glebokosc) : base(masa, wysokosc, waga, glebokosc)
    {
        NumerSeryjny += Contener.NextNumerSeryjny;
    }
    public string NumerSeryjny { get; set; } = "KON-G-";
}