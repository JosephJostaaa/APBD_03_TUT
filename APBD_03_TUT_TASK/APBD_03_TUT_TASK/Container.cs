namespace APBD_03_TUT_TASK;

public abstract class Container
{
    private static int Id { get; set; } = 1;
    public int LocalId { get; set; }

    public double CargoMass
    {
        get; 
        set;
    }
    public double Height { get; set; }
    public double TareWeight { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { set; get;}
    public double MaxPayload { get; set; }

    public Container( double height, double tareWeight, double depth, double maxPayload)
    {
        Height = height;
        TareWeight = tareWeight;
        Depth = depth;
        MaxPayload = maxPayload;
        LocalId = Id++;
    }

    public virtual void LoadContainer(double mass)
    {
        if (mass > MaxPayload)
        {
            throw new OverfillException("The amount of payload to be loaded is greater than the max payload.");
        }
        CargoMass = mass;
        
    }

    public virtual void EmptyContainer()
    {
        CargoMass = 0;
        Console.WriteLine("The container's " + SerialNumber+" was unloaded.");
    }

    public override string ToString()
    {
        return
            "Container info: " + $"{nameof(CargoMass)}: {CargoMass}, {nameof(Height)}: {Height}, {nameof(TareWeight)}: {TareWeight}, {nameof(Depth)}: {Depth}, {nameof(SerialNumber)}: {SerialNumber}, {nameof(MaxPayload)}: {MaxPayload}";
    }
}