namespace ConsoleApp1;

public class Ship
{
    private List<Contener> Conteners { get; set; }
    public double MaxSpeed { get; set; }
    private int MaxCapacity { get; set; }
    private double MaxWeight { get; set; }

    public Ship(double maxSpeed, int maxCapacity, double maxWeight)
    {
        MaxSpeed = maxSpeed;
        MaxCapacity = maxCapacity;
        MaxWeight = maxWeight;
    }

    public void loadConteners(Contener contener)
    {
        if (Conteners.Count >= MaxCapacity)
        {
            Console.WriteLine("You can not add container, ship is full");
        }
        else if (currenLoad() + contener.MasaLadunku > MaxWeight*1000)
        {
            Console.WriteLine(
                "You can not add container, maxYou cannot add this container, the permissible weight of the ship has been exceeded!");
        }
        else
        {
            Conteners.Add(contener);
        }
    }

    private double currenLoad()
    {
        double totalWeight = 0;

        foreach (var container in Conteners)
        {
            totalWeight += container.MasaLadunku + container.Waga;
        }

        return totalWeight;
    }
}