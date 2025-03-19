namespace ConsoleApp1;

public class KontenerNaPlyny : Contener, IHazardNotifier
{
    public KontenerNaPlyny(int wysokosc, float waga, float glebokosc, double maxLadownosc) : base(wysokosc,waga, glebokosc, maxLadownosc)
    {
        NumerSeryjny += Contener.NextNumerSeryjny;
    }

    public string NumerSeryjny { get; set; } = "KON-L-";
    public bool IsDangerous { get; set; } = false;


    public override void ZaladujKontener(int masaLadunku)
    {
        if (masaLadunku > (MaxLadownosc - MasaLadunku))
        {
            throw new OverflowException("You try to overfill container "+ NumerSeryjny+ " !");
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
    
    public void warning()
    {
        Console.WriteLine("Niebezpieczńśtwo związane z przepełnieniem w kontenerze " + NumerSeryjny);
    }
}