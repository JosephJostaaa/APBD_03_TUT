namespace APBD_03_TUT_TASK;

public class Ship
{
    public List<Container> Containers { get; } = new List<Container>();
    public double MaxSpeed { get; set; }
    public int MaxNumberOfContainers { get; set; }
    public double MaxWeightOfContainers { get; set; }

    public void LoadContainer(Container container)
    {
        Containers.Add(container);
    }
    
    
    
    
}