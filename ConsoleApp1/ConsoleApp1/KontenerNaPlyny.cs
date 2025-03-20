namespace ConsoleApp1;

public class KontenerNaPlyny : Contener, IHazardNotifier
{
    public KontenerNaPlyny(int wysokosc, double waga, int glebokosc, double maxLadownosc) : base(
        wysokosc, waga, glebokosc, maxLadownosc)
    {
        NumerSeryjny += Contener.NextNumerSeryjny;
    }
    private string NumerSeryjny { get; set; } = "KON-L-";
    private bool IsDangerous { get; set; } = false;


    public void ZaladujKontener(int masaLadunku, bool isDangerous = false)
    {
        IsDangerous = isDangerous;
        if (masaLadunku > (MaxLadownosc - MasaLadunku))
        {
            throw new OverflowException("You try to overfill container " + NumerSeryjny + " !");
        }
        
        if (IsDangerous)
        {
            if (masaLadunku > (MaxLadownosc - MasaLadunku) * 0.5)
            {
                warning();
            }
        }
        else
        {
            if (masaLadunku > (MaxLadownosc - MasaLadunku) * 0.9)
            {
                warning();
            }
        }
        MasaLadunku += masaLadunku;
    }

    public void warning()
    {
        Console.WriteLine("Niebezpieczńśtwo związane z przepełnieniem w kontenerze " + NumerSeryjny);
    }

    public override void getInfo()
    {
        Console.WriteLine("Kontener o numerze: " + NumerSeryjny + "\n" + "o aktualnej masie " + (MasaLadunku + Waga) +" kg" + "\n" +
                          (IsDangerous ? " Zawiera niebezpieczny ładunek" : "nie zawiera niebezpiczenych ładunków")+ "\n");
    }
}