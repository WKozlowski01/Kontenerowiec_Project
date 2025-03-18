namespace ConsoleApp1;

public class KontenerNaPlyny : Contener, IHazardNotifier
{
    public KontenerNaPlyny(int masa, int wysokosc, float waga, float glebokosc, double maxLadownosc) : base(masa,
        wysokosc,
        waga, glebokosc, maxLadownosc)
    {
        NumerSeryjny += Contener.NextNumerSeryjny;
    }

    public string NumerSeryjny { get; set; } = "KON-L-";
    public bool IsDangerous { get; set; } = false;


    public void ZaladujKontener(int masaLadunku)
    {
        if (masaLadunku > (MaxLadownosc - MasaLadunku))
        {
            //Throw exception
        }
        else
        {
            MasaLadunku = masaLadunku;
        }

        if (IsDangerous)
        {
            if (masaLadunku > (MaxLadownosc - MasaLadunku) * 0.5)
            {
                warning();
            }
        }else 
        {
            if (masaLadunku > (MaxLadownosc - MasaLadunku) * 0.9)
            {
                warning();
            }
        }
    }

    public void OproznijLadunek()
    {
        MasaLadunku = 0;
    }


    public void warning()
    {
        Console.WriteLine("Niebezpieczńśtwo związane z przepełnieniem w kontenerze " + NumerSeryjny);
    }
}