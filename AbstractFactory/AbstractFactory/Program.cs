using System;
using System.Runtime.InteropServices;

namespace AbstractFactory
{
    class Program
    {
        public interface IFontsFactory
        {
            IAbstractLetterA WriteLetterA();

            IAbstractLetterB WriteLetterB();
        }

        class UnderlineFontFactory : IFontsFactory
        {
            public IAbstractLetterA WriteLetterA()
            {
                return new UnderlineLetterA();
            }

            public IAbstractLetterB WriteLetterB()
            {
                return new UnderlineLetterB();
            }
        }

        class GoldBackgroundFontFactory : IFontsFactory
        {
            public IAbstractLetterA WriteLetterA()
            {
                return new GoldBackgroundLetterA();
            }

            public IAbstractLetterB WriteLetterB()
            {
                return new GoldBackgroundLetterB();
            }
        }


        public interface IAbstractLetterA
        {
            string UsefulFunctionA();
        }

        public interface IAbstractLetterB
        {
            string UsefulFunctionB();
        }

        class UnderlineLetterA : IAbstractLetterA
        {
            public string UsefulFunctionA()
            {
                return "\x1b[4m A";
            }
        }

        class UnderlineLetterB : IAbstractLetterB
        {
            public string UsefulFunctionB()
            {
                return "\x1b[4m B";
            }
        }

        class GoldBackgroundLetterA : IAbstractLetterA
        {
            public string UsefulFunctionA()
            {
                return "\x1b[43m A";
            }
        }

        class GoldBackgroundLetterB : IAbstractLetterB
        {
            public string UsefulFunctionB()
            {
                return "\x1b[43m B";
            }
        }

        static void Main()
        {

            UnderlineFontFactory underlineFontFactory = new UnderlineFontFactory();
            GoldBackgroundFontFactory goldBackgroundFontFactory = new GoldBackgroundFontFactory();

            var underlineLetterA = underlineFontFactory.WriteLetterA();
            var underlineLetterB = underlineFontFactory.WriteLetterB();
            var goldBackgroundLetterA = goldBackgroundFontFactory.WriteLetterA();
            var goldBackgroundLetterB = goldBackgroundFontFactory.WriteLetterB();

            Console.WriteLine(underlineLetterA.UsefulFunctionA());
            Console.WriteLine(underlineLetterB.UsefulFunctionB());
            Console.WriteLine(goldBackgroundLetterA.UsefulFunctionA());
            Console.WriteLine(goldBackgroundLetterB.UsefulFunctionB());

            Console.WriteLine("\x1b[0m");

        }
    }
}
