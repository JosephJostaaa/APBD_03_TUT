namespace APBD_03_TUT_TASK;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool IsHazardous { get; }
    public LiquidContainer(double mass, double height, double tareWeight, double depth, bool isHazardous) : base(mass, height, tareWeight, depth)
    {
        SerialNumber = "KON-LiquidContainer-"+ID;
        IsHazardous = isHazardous;
    }


    public void sendNotification()
    {
        Console.WriteLine("Hazardous");
    }

    public override void LoadContainer(double mass)
    {
        base.LoadContainer(mass);
        if (IsHazardous)
        {
            if (mass > MaxPayload * 0.5)
            {
                sendNotification();
            }
            
        }
        else
        {
            if (mass > MaxPayload * 0.9)
            {
                sendNotification();
            }
        }
    }
}