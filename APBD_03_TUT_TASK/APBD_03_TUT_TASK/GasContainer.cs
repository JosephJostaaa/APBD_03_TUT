namespace APBD_03_TUT_TASK;

public class GasContainer : Container, IHazardNotifier
{
    public GasContainer(double height, double tareWeight, double depth, double maxPayload) : base(height, tareWeight, depth, maxPayload)
    {
        SerialNumber = "KON-GasContainer-"+LocalId;
    }

    public void sendNotification()
    {
        Console.WriteLine("The container " + SerialNumber + " is in a hazardous situation");
    }

    public override void EmptyContainer()
    {
        CargoMass *= 0.05;
        Console.WriteLine("The container's " + SerialNumber+" was unloaded. Its mass is now " + CargoMass);
    }
    
    
}