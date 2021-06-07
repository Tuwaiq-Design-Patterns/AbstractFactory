using System;

namespace AbsractFactory
{
    class Program
    {
        static void Main(string[] args)

        {
            // Microsoft Screen 
            Laptop Ms = new Microsoft();
            MSscreen Sins = (MSscreen)Ms.createScreen();
            Console.WriteLine(Ms.createScreen().GetType());
            Console.WriteLine(Sins.FormatScreen());
            Console.WriteLine();
            // Microsoft KeyBoard
            MSkeyboard Kins = (MSkeyboard)Ms.createKeyboard();
            Console.WriteLine(Kins.FormatKeyboard());
            Console.WriteLine(Ms.createKeyboard().GetType());
            Console.WriteLine();
            Console.WriteLine();

            // Mac Keyboard
            Laptop Mc = new Mac();
            MacKeyboard MKins = (MacKeyboard)Mc.createKeyboard();
            Console.WriteLine(Mc.createKeyboard().GetType());
            Console.WriteLine(MKins.FormatKeyboard());
            Console.WriteLine();
            // Mac Screen 
            MacScreen MSins = (MacScreen)Mc.createScreen();
            Console.WriteLine(Mc.createScreen().GetType());
            Console.WriteLine(MSins.FormatScreen());

        }
    }

    abstract class Laptop
    {
        public abstract Screen createScreen();
        public abstract Keyboard createKeyboard();

    }

    class Microsoft : Laptop
    {
       
        public override Screen createScreen() 
        {
            return new MSscreen();
        }

        public override Keyboard createKeyboard() 
        {
            return new MSkeyboard();
        }
    }
    class Mac : Laptop
    {

        public override Screen createScreen()
        {
            return new MacScreen();
        }

        public override Keyboard createKeyboard()
        {
            return new MacKeyboard();
        }
    }
    interface Screen
    {
        public string FormatScreen();
    }
    interface Keyboard
    {
        public string FormatKeyboard();
    }
    class MSscreen : Screen
    {
        public string FormatScreen()
        {
            return "this Screen is formated in Microsoft style";
        }
    }
    class MSkeyboard : Keyboard
    {
        public string FormatKeyboard()
        {
            return "this keyboard is formated in Microsoft style";
        }
    }
    class MacScreen : Screen
    {
        public string FormatScreen()
        {
            return "this Screen is formated in Mac Style ";
        }
    }
    class MacKeyboard : Keyboard
    {
        public string FormatKeyboard()
        {
            return "this keyboard is formated in Mac Style ";
        }
    }

}
