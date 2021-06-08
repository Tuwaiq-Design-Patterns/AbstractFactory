using AbstractFactory;

public class NestleFactory : BottleFactory
{
    public WaterBottle GetWaterBottle()
    {
        return new NestleWaterBottle();
    }

    public JuiceBottle GetJuiceBottle()
    {
        return new NestleJuiceBottle();
    }
}