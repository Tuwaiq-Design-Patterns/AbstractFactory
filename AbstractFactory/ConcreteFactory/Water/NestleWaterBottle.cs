using AbstractFactory;

public class NestleWaterBottle : WaterBottle
{
    public string GetBottleDetails()
    {
        return "Brand: Nestle, Size: 330 mL, Color: transparent";
    }
}