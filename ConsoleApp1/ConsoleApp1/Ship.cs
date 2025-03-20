using System.Security.AccessControl;

namespace ConsoleApp1;

public class Ship(double maxSpeed, int maxCapacity, double maxWeight)
{
    public List<Contener> Conteners { get; set; } = new List<Contener>();
    public double MaxSpeed { get; set; } = maxSpeed;
    private int MaxCapacity { get; set; } = maxCapacity;
    private double MaxWeight { get; set; } = maxWeight;
    public double CurrentWeight { get; set; } = 0;

    public void loadConteners(Contener contener)
    {
        if (contener.NaStatku)
        {
            Console.WriteLine("Kontener " + contener.getId() + " jest już na jakimś statku\n");
        }

        if (Conteners.Count >= MaxCapacity)
        {
            Console.WriteLine("You can not add container, ship is full\n");
        }
        else if (CurrentWeight + contener.MasaLadunku + contener.Waga > MaxWeight * 1000)
        {
            Console.WriteLine("You can not add container,the permissible weight of the ship has been exceeded!\n");
        }
        else
        {
            Conteners.Add(contener);
            Console.WriteLine("kontener został załadowany na statek \n");
            contener.NaStatku = true;
            CurrentWeight += contener.MasaLadunku + contener.Waga;
        }
    }

    public void loadConteners(List<Contener> inputContener)
    {
        foreach (var x in inputContener)
        {
            loadConteners(x);
        }
    }

    public void getInfo()
    {
        Console.WriteLine(
            "waga kontenerów na statku: " + CurrentWeight / 1000 + " tony" + "\n" +
            "Ilość kontenerów: " + Conteners.Count + "\n" +
            "Maksymalna prędkość statku: " + MaxSpeed + "\n" +
            "Maksymalna ładowność statku: " + MaxWeight + " ton" + "\n" +
            "Maksymalna liczba kontenerów na statku: " + MaxCapacity + "\n"
        );
    }

    public void getContenerInfo()
    {
        Console.WriteLine("Na statku zanjdują się kontenery:");
        foreach (var x in Conteners)
        {
            Console.WriteLine(x.getId() + " \t");
        }
        
    }

    public void removeContener(Contener contener)
    {
        if (Conteners.Contains(contener))
        {
            Conteners.Remove(contener);
            CurrentWeight = CurrentWeight - contener.MasaCalkowita;
            contener.NaStatku = false;
            Console.WriteLine("Kontener został wyładowany ze statku\n");
        }
        else
        {
            Console.WriteLine("Statek nie zawiera kontenera "+contener.getId()+"\n");
        }
    }
}