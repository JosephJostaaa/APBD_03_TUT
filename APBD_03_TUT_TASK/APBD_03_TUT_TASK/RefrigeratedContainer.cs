﻿namespace APBD_03_TUT_TASK;

public class RefrigeratedContainer : Container

{
    public string TypeOfProduct { get; set; }
    public double Temperature { get; set; }
    public Dictionary<string, double> ProductTemperature { get; }
    public RefrigeratedContainer(double mass, double height, double tareWeight, double depth, string typeOfProduct, double temperature) : base(mass, height, tareWeight, depth)
    {
        ProductTemperature = new Dictionary<string, double>();
        ProductTemperature.Add("Bananas", 13.3);
        ProductTemperature.Add("Chocolate", 18);
        ProductTemperature.Add("Fish", 2);
        ProductTemperature.Add("Meat", -15);
        ProductTemperature.Add("Ice cream", -18);
        ProductTemperature.Add("Frozen pizza", -30);
        ProductTemperature.Add("Cheese", 7.2);
        ProductTemperature.Add("Sausages", 5);
        ProductTemperature.Add("Butter", 20.5);
        ProductTemperature.Add("Eggs", 19);


        if (!ProductTemperature.ContainsKey(typeOfProduct))
        {
            throw new Exception($"The type of {typeOfProduct} does not exist.");
        }
        if (temperature < ProductTemperature[typeOfProduct])
        {
            throw new Exception();
        }
        
        TypeOfProduct = typeOfProduct;
        Temperature = temperature;
    }
    
    
}