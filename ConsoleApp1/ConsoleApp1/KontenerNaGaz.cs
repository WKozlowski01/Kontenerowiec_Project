namespace ConsoleApp1;

public class KontenerNaGaz : Contener, IHazardNotifier
{
    public string NumerSeryjny { get; set; } = "KON-G-";
    public int Pressure { get; set; }

    public KontenerNaGaz(int masa, int wysokosc, float waga, float glebokosc, double maxLadownosc) : base(masa,
        wysokosc, waga, glebokosc, maxLadownosc)
    {
        NumerSeryjny += Contener.NextNumerSeryjny;
    }

    public void ZaladujKontener(double masaLadunku)
    {
        if (masaLadunku > (MaxLadownosc - MasaLadunku))
        {
            //throw exception
        }
        else
        {
            MasaLadunku = masaLadunku;
        }
    }

    public void OproznijLadunek()
    {
        MasaLadunku = MasaLadunku * 0.05;
    }


    public void warning()
    {
        Console.WriteLine("Niebezpieczńśtwo związane z opróżnieniem kontenera " + NumerSeryjny);
    }
}