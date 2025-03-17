namespace APBD_03_TUT_TASK;

public abstract class Container
{
    public static int ID { get; } = 1;

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

    public Container(double mass, double height, double tareWeight, double depth)
    {
        CargoMass = mass;
        Height = height;
        TareWeight = tareWeight;
        Depth = depth;

    }

    public virtual void LoadContainer(double mass)
    {
        if (mass > MaxPayload)
        {
            throw new Exception();
        }
        CargoMass = mass;
        
    }

    public virtual void EmptyContainer()
    {
        CargoMass = 0;
    }
    
}