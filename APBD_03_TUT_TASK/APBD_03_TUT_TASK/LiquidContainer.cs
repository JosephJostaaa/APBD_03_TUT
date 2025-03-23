namespace APBD_03_TUT_TASK;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool IsHazardous { get; }
    public LiquidContainer(double height, double tareWeight, double depth, bool isHazardous, double maxPayload) : base(height, tareWeight, depth, maxPayload)
    {
        SerialNumber = "KON-LiquidContainer-"+LocalId;
        IsHazardous = isHazardous;
    }


    public void sendNotification()
    {
        Console.WriteLine("The container " + SerialNumber + " is in a hazardous situation");
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

    public override string ToString()
    {
        return $"{base.ToString()}, {nameof(IsHazardous)}: {IsHazardous}";
    }
}