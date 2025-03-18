namespace ConsoleApp1;

// Masę ładunku (w kilogramach)
// Wysokość (w centymetrach)
// Waga własna (waga samego kontenera, w kilogramach)
// Głębokość (w centymetrach)
// Numer seryjny
// Format numeru to KON-C-1
// Pierwszy człon numery to zawsze "KON"
// Drugi człon reprezentuje rodzaj kontenera
//Trzeci człon to liczba. Liczby powinny być unikalne. Nie powinno być możliwości powstania dwóch kontenerów o tym
//samym numerze. Numery powinny być generowane przez system.
//Maksymalna ładowność danego kontenera w kilogramach

public abstract class Contener
{

    
    
    public Contener(int masa, int wysokosc, float waga, float glebokosc)
    {
        masa = Masa;
        wysokosc = wysokosc;
        waga = waga;
        glebokosc = glebokosc;
        NextNumerSeryjny++;
    }

    

    public int Masa {get; set; }
    public int Wysokosc { get; set; }
    public float Waga { get; set; }
    public float Glebokosc { get; set; }
  public static int NextNumerSeryjny { get; set; }=0;


    public int MaxLadownosc { get; set; }

    
    public void OproznijLadunek()
    {
        //TODO
    }

    public void ZaladujKontener(int MasaLadunku)
    {
        if (MasaLadunku > MaxLadownosc)
        {
            //TODO overfill exception
        }
    }

}

