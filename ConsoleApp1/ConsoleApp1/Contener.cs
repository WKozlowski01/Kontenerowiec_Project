namespace ConsoleApp1;
public abstract class Contener
{
    public int Wysokosc { get; set; }
    public double Waga { get; set; } = 0;
    public int Glebokosc { get; set; }
    protected static int NextNumerSeryjny { get; set; } = 0;

    public double MasaLadunku { get; set; } = 0;

    protected Contener(int wysokosc, double waga, int glebokosc,double maxLadownosc)
    {
        Wysokosc = wysokosc;
        Waga = waga;
        Glebokosc = glebokosc;
        NextNumerSeryjny++;
        MaxLadownosc = maxLadownosc;
    }

    protected double MaxLadownosc { get; set; }


    public virtual void OproznijLadunek()
    {
        MasaLadunku = 0;
        Console.WriteLine("Kontener rozładowany");
    }

    public abstract void getInfo();

}