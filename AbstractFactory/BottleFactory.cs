using AbstractFactory;

public interface BottleFactory
{
    public abstract WaterBottle GetWaterBottle();
    public abstract JuiceBottle GetJuiceBottle();
}