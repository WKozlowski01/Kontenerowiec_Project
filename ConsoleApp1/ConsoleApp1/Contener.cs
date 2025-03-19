namespace ConsoleApp1;
public abstract class Contener
{
    
    public int Masa { get; set; }
    public int Wysokosc { get; set; }
    public float Waga { get; set; }
    public float Glebokosc { get; set; }
    protected static int NextNumerSeryjny { get; set; } = 0;

    protected double MasaLadunku { get; set; } = 0;

    protected Contener(int wysokosc, float waga, float glebokosc,double maxLadownosc)
    {
       
        wysokosc = Wysokosc;
        waga = Waga;
        glebokosc = Glebokosc;
        NextNumerSeryjny++;
    }

    public int MaxLadownosc { get; set; }


    public virtual void OproznijLadunek()
    {
        MasaLadunku = 0;
    }

    public abstract void ZaladujKontener(int masaLadunku);
}