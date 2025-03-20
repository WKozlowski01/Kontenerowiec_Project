namespace ConsoleApp1;

public class KontenerNaGaz : Contener, IHazardNotifier
{
    private string NumerSeryjny { get; set; } = "KON-G-";
    public double Pressure { get; set; } = 1.0;

    public KontenerNaGaz(int wysokosc, double waga, int glebokosc, double maxLadownosc) : base(wysokosc, waga,
        glebokosc, maxLadownosc)
    {
        NumerSeryjny += Contener.NextNumerSeryjny;
    }

    public override void OproznijLadunek()
    {
        MasaLadunku = MasaLadunku * 0.05;
        Console.WriteLine("Konter rozładowny, w środku pozostało: "+MasaLadunku+ " kg ładunku");
    }

    public void ZaladujKontener(int masaLadunku)
    {
        if ((masaLadunku + MasaLadunku) > MaxLadownosc)
        {
            throw new OverflowException("You try to overfill container: " + NumerSeryjny + " !");
        }
        MasaLadunku += masaLadunku;
        
    }

    public void warning()
    {
        Console.WriteLine("Niebezpieczńśtwo związane z opróżnieniem kontenera " + NumerSeryjny);
    }

    public override void getInfo()
    {
        Console.WriteLine("Kontener o numerze: " + NumerSeryjny + "\n" + "o aktualnej masie " + (MasaLadunku + Waga) +
                          " kg" + "\n" + "jest pod ciśnieneim " + Pressure + " atmosfer"+ "\n");
    }
}