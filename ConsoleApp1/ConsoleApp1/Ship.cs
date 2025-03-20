namespace ConsoleApp1;

public class Ship(double maxSpeed, int maxCapacity, double maxWeight)
{
    private List<Contener> Conteners { get; set; }= new List<Contener>();
    public double MaxSpeed { get; set; } = maxSpeed;
    private int MaxCapacity { get; set; } = maxCapacity;
    private double MaxWeight { get; set; } = maxWeight;
    public double CurrentWeight { get; set; } = 0;

    public void loadConteners(Contener contener)
    {
        if (Conteners.Count >= MaxCapacity)
        {
            Console.WriteLine("You can not add container, ship is full");
        }
        else if (CurrentWeight + contener.MasaLadunku + contener.Waga > MaxWeight*1000)
        {
            Console.WriteLine("You can not add container,the permissible weight of the ship has been exceeded!");
        }
        else
        {
            Conteners.Add(contener);
            CurrentWeight += contener.MasaLadunku + contener.Waga;
        }
    }

    public void getInfo()
    {
        Console.WriteLine(
            "waga kontenerów na statku: " + CurrentWeight/1000 +" tony"+ "\n"+ 
            "Ilość kontenerów: "+ Conteners.Count + "\n"+
            "Maksymalna prędkość statku: " + MaxSpeed + "\n"+
            "Maksymalna ładowność statku: "+ MaxWeight + " ton"+ "\n"+
            "Maksymalna liczba kontenerów na statku: " + MaxCapacity + "\n"
            );
    }
}