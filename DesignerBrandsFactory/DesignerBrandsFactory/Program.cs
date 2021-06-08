using System;

namespace DesignerBrandsFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            DesignerBrandsAbstractFactory SaintLaurentLeatherGoods = new YvesSaintLaurent();
            DesignerBrandsAbstractFactory LouisVuittonLeatherGoods = new LouisVuitton();

            Console.WriteLine("Purse variants:");
            SaintLaurentLeatherGoods.LeatherCraftPurse().Purse();
            LouisVuittonLeatherGoods.LeatherCraftPurse().Purse();

            Console.WriteLine("\n");

            Console.WriteLine("Belt variants:");
            SaintLaurentLeatherGoods.LeatherCraftBelt().Belt();
            LouisVuittonLeatherGoods.LeatherCraftBelt().Belt();
        }

    }
    public interface DesignerBrandsAbstractFactory
    {
        public IPurse LeatherCraftPurse();
        public IBelt LeatherCraftBelt();
    }

    class YvesSaintLaurent : DesignerBrandsAbstractFactory
    {
        public IPurse LeatherCraftPurse()
        {
            return new YSLPurse();
        }

        public IBelt LeatherCraftBelt()
        {
            return new YSLBelt();
        }
    }
    class LouisVuitton : DesignerBrandsAbstractFactory
    {
        public IPurse LeatherCraftPurse()
        {
            return new LVPurse();
        }

        public IBelt LeatherCraftBelt()
        {
            return new LVBelt();
        }
    }

    public class YSLPurse : IPurse
    {
        public void Purse()
        {
            Console.WriteLine("Sleek, black, calfskin bag from YSL");
        }
    }

    public class YSLBelt : IBelt
    {
        public void Belt()
        {
            Console.WriteLine("Skinny white calfskin belt from YSL");

        }
    }

    public class LVPurse : IPurse
    {
        public void Purse()
        {
            Console.WriteLine("A brown purse embossed with LV's signature monogram");

        }
    }

    public class LVBelt : IBelt
    {

        public void Belt()
        {
            Console.WriteLine("A brown belt decorated with LV's signature monogram");
        }
    }

    public interface IPurse
    {
        public void Purse();
    }

    public interface IBelt
    {
        public void Belt();
    }
}