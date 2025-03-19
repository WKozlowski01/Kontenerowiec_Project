namespace ConsoleApp1;

public class KontenerNaGaz : Contener, IHazardNotifier
{
    public string NumerSeryjny { get; set; } = "KON-G-";
    public int Pressure { get; set; }

    public KontenerNaGaz(int wysokosc, float waga, float glebokosc, double maxLadownosc) : base(wysokosc, waga, glebokosc, maxLadownosc)
    {
        NumerSeryjny += Contener.NextNumerSeryjny;
    }
    
    public override void OproznijLadunek()
    {
        MasaLadunku = MasaLadunku * 0.05;
    }

    public override void ZaladujKontener(int masaLadunku)
    {
        if (masaLadunku > (MaxLadownosc - MasaLadunku))
        {
            throw new OverflowException("You try to overfill container: "+NumerSeryjny+ " !");
            
        }
        else
        {
            MasaLadunku = masaLadunku;
        }
    }


    public void warning()
    {
        Console.WriteLine("Niebezpieczńśtwo związane z opróżnieniem kontenera " + NumerSeryjny);
    }
}