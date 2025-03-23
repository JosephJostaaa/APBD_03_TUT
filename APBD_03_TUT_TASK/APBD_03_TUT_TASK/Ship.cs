namespace APBD_03_TUT_TASK;

public class Ship
{
    public List<Container> Containers { get; }
    public double MaxSpeed { get; set; }
    public int MaxNumberOfContainers { get; set; }
    public double MaxWeightOfContainers { get; set; }
    private double _totalWeight;

    public Ship(double maxSpeed, int maxNumberOfContainers, double maxWeightOfContainers)
    {
        MaxSpeed = maxSpeed;
        MaxNumberOfContainers = maxNumberOfContainers;
        MaxWeightOfContainers = maxWeightOfContainers;
        Containers = new List<Container>();
        _totalWeight = 0;
    }

    public void LoadContainer(Container container)
    {
        if (Containers.Count >= MaxNumberOfContainers)
        {
            Console.WriteLine(Containers.Count + " container is more than maximum number of containers.");
            return;
        }
        if (MaxWeightOfContainers < _totalWeight + container.CargoMass / 1000.0 + container.TareWeight / 1000.0)
        {
            Console.WriteLine("The total mass of the containers is larger than the maximum allowed");
            return;
        }

        if (FindBySerialNumber(container.SerialNumber) != null)
        {
            Console.WriteLine("Container with id "+container.SerialNumber + " has been already added.");
            return;
        }

        Containers.Add(container);
        Console.WriteLine("Loaded container with id " + container.SerialNumber);
        _totalWeight += container.CargoMass / 1000.0 + container.TareWeight / 1000.0;

    }

    public void LoadContainers(List<Container> containers)
    {
        foreach (var container in containers)
        {
            LoadContainer(container);
        }

    }

    public void RemoveContainer(string serialNumber)
    {
        Container? container = FindBySerialNumber(serialNumber);
        if (container != null)
        {
            Containers.Remove(container);
            Console.WriteLine("Removed container with serial number " + container.SerialNumber);
        }
        else
        {
            Console.WriteLine("Could not find container with serial number " + serialNumber);
        }
    }

    public void ReplaceContainer(string serialNumber, Container container)
    {
        Container? found = FindBySerialNumber(serialNumber);
        if (found != null)
        {
            Containers.Remove(found);
            Containers.Add(container);
            Console.WriteLine("Replace container with serial number " + found.SerialNumber + " with container with serial number " + container.SerialNumber);
        }
        else
        {
            Console.WriteLine("Could not find container with serial number " + serialNumber);
        }
    }

    public void TransferContainer(string serialNumber, Ship ship)
    {
        Container? found = FindBySerialNumber(serialNumber);
        if (found != null)
        {
           ship.LoadContainer(found);
           Containers.Remove(found);
        }
        else
        {
            Console.WriteLine("Could not find container with serial number " + serialNumber);
        }
    }

    private Container? FindBySerialNumber(string serialNumber)
    {
        return Containers.Find(c => c.SerialNumber.Equals(serialNumber));
    }

    public override string ToString()
    {
        return
            "Ship info: "+$"{nameof(_totalWeight)}: {_totalWeight}, {nameof(Containers)}: {Containers}, {nameof(MaxSpeed)}: {MaxSpeed}, {nameof(MaxNumberOfContainers)}: {MaxNumberOfContainers}, {nameof(MaxWeightOfContainers)}: {MaxWeightOfContainers}";
    }
}