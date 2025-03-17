namespace APBD_03_TUT_TASK;

public class GasContainer : Container, IHazardNotifier
{
    public GasContainer(double mass, double height, double tareWeight, double depth) : base(mass, height, tareWeight, depth)
    {
    }

    public void sendNotification()
    {
        Console.WriteLine("GasContainer");
    }

    public override void EmptyContainer()
    {
        CargoMass *= 0.05;
    }
}