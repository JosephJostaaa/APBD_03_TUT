// See https://aka.ms/new-console-template for more information

using APBD_03_TUT_TASK;

Ship ship = new Ship(23, 10, 20);
Ship ship2 = new Ship(23, 10, 20);

Container container = new LiquidContainer(2, 200, 1.75, true, 500);
Container refContainer = new RefrigeratedContainer(2, 200, 1.75, "Bananas", 10, 500);

container.LoadContainer(300);
refContainer.LoadContainer(300);

List<Container> containers = new List<Container>();
containers.Add(refContainer);
containers.Add(container);

ship.LoadContainer(container);
ship.LoadContainers(containers);

Console.WriteLine(ship.Containers.Count);

ship.RemoveContainer(container.SerialNumber);
container.EmptyContainer();

Container gasContainer = new GasContainer(1.8, 200, 1.5, 100);
gasContainer.LoadContainer(50);
ship.ReplaceContainer(refContainer.SerialNumber, gasContainer);

ship.TransferContainer(gasContainer.SerialNumber, ship2);

Console.WriteLine(ship);
Console.WriteLine(gasContainer);



