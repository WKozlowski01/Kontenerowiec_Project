namespace ConsoleApp1;

public class KontenerNaPlyny : Contener
{
    public KontenerNaPlyny(int masa, int wysokosc, float waga, float glebokosc) : base(masa, wysokosc, waga, glebokosc)
    {
        NumerSeryjny += Contener.NextNumerSeryjny;
    }    
    public string NumerSeryjny { get; set; } = "KON-L-";
    public bool IsDangerous { get; set; } = false;
    

}