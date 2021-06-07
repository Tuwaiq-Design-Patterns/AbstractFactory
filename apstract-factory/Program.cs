using System;

namespace apstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Berain factory 
            AbstractFactory Berain = new BerainFactory();
            AbstractSparklingWater BerainSparklingWater = Berain.CreateSparklingWater();
            Console.WriteLine(BerainSparklingWater.GetSparklingWaterInfo());
            AbstractNormalWater BerainNormalWater = Berain.CreateNormalWater();
            Console.WriteLine(BerainNormalWater.GetNormalWaterInfo());

            // Hana factory 

            AbstractFactory Hana = new HanaFactory();
            AbstractSparklingWater HanaSparklingWater = Hana.CreateSparklingWater();
            Console.WriteLine(HanaSparklingWater.GetSparklingWaterInfo());
            AbstractNormalWater HanaNormalWater = Hana.CreateNormalWater();
            Console.WriteLine(HanaNormalWater.GetNormalWaterInfo());

        }
    }
    abstract class AbstractFactory
    {
        public abstract AbstractNormalWater CreateNormalWater();
        public abstract AbstractSparklingWater CreateSparklingWater();
    }
    class BerainFactory : AbstractFactory
    {
        public override AbstractNormalWater CreateNormalWater()
        {
            return new BerainNormalWater();
        }
        public override AbstractSparklingWater CreateSparklingWater()
        {
            return new BerainSparklingWater();
        }
    }
    class HanaFactory : AbstractFactory
    {
        public override AbstractNormalWater CreateNormalWater()
        {
            return new HanaNormalWater();
        }
        public override AbstractSparklingWater CreateSparklingWater()
        {
            return new HanaSparklingWater();
        }
    }
    public  interface AbstractNormalWater
    {
        public string GetNormalWaterInfo();

    }
    public interface AbstractSparklingWater
    {
        public string GetSparklingWaterInfo();
    }
    class BerainNormalWater : AbstractNormalWater
    {
        public string GetNormalWaterInfo()
        {
           return "Berain Normal Water";
        }
    }
    class BerainSparklingWater : AbstractSparklingWater
    {
        public string GetSparklingWaterInfo()
        {
            return "Berain Sparkling Water";
        }
    }
    class HanaNormalWater : AbstractNormalWater
    {
        public string GetNormalWaterInfo()
        {
            return "Hana Normal Water";
        }
    }
    class HanaSparklingWater : AbstractSparklingWater
    {
        public string GetSparklingWaterInfo()
        {
            return "Hana Sparkling Water";
        }
    }
}
