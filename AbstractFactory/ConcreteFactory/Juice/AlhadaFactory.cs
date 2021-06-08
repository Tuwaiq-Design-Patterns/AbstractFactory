using AbstractFactory;

public class AlhadaFactory : BottleFactory
{
    public WaterBottle GetWaterBottle()
    {
        return new AlhadaWaterBottle();
    }

    public JuiceBottle GetJuiceBottle()
    {
        return new AlhadaJuiceBottle();
    }
}