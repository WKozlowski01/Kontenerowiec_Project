namespace ConsoleApp1;

public class KontenerNaGaz : Contener, IHazardNotifier
{
    private string NumerSeryjny { get; set; } = "KON-G-";
    public double Pressure { get; set; } = 1.0;
  

    public KontenerNaGaz(int wysokosc, double waga, int glebokosc, double maxLadownosc) : base(wysokosc, waga,
        glebokosc, maxLadownosc)
    {
        MaxLadownosc = maxLadownosc;
        NumerSeryjny += Contener.NextNumerSeryjny;
       
    }

    public override void OproznijLadunek()
    {
        MasaLadunku = MasaLadunku * 0.05;
        Console.WriteLine("Konter rozładowny, w środku pozostało: "+MasaLadunku+ " kg ładunku"+"\n");
        MasaCalkowita = MasaLadunku+Waga;
    }

    public void ZaladujKontener(int masaLadunku)
    {
        if ((masaLadunku + MasaLadunku) > MaxLadownosc)
        {
            throw new OverflowException("You try to overfill container: " + NumerSeryjny + " !"+"\n");
        }
        MasaLadunku += masaLadunku;
        MasaCalkowita += masaLadunku;

    }

    public void warning()
    {
        Console.WriteLine("Niebezpieczńśtwo związane z opróżnieniem kontenera " + NumerSeryjny+"\n");
    }

    public override void getInfo()
    {
        Console.WriteLine("Kontener o numerze: " + NumerSeryjny + "\n" + "o aktualnej masie " + MasaCalkowita +
                          " kg" + "\n" + "jest pod ciśnieneim " + Pressure + " atmosfer"+ "\n");
    }

    public override string getId()
    {
        return NumerSeryjny;
    }
}