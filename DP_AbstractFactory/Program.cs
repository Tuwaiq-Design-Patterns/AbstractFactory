using System;

namespace DP_AbstractFactory
{
    public interface IGUIFactory
    {
        IButton createButton();
        ICheckBox createCheckbox();
    }

    class WinFactory : IGUIFactory
    {
        public IButton createButton()
        {
            return new WinButton();
        }

        public ICheckBox createCheckbox()
        {
            return new WinCheckBox();
        }
    }
    class MacFactory : IGUIFactory
    {
        public IButton createButton()
        {
            return new MacButton();
        }

        public ICheckBox createCheckbox()
        {
            return new MacCheckBox();
        }
    }


    // products
    public interface IButton
    {

    }
    class WinButton : IButton
    {

        public WinButton()
        {
        }
        public override string ToString()
        {
            return "Windows button";
        }

    }
    class MacButton : IButton
    {

        public MacButton()
        {
        }
        public override string ToString()
        {
            return "Mac button";
        }
    }

    public interface ICheckBox
    {

    }
    class WinCheckBox : ICheckBox
    {

        public WinCheckBox()
        {
        }
        public override string ToString()
        {
            return "Windows Checkbox" ;
        }

    }
    class MacCheckBox : ICheckBox
    {

        public MacCheckBox()
        {
        }
        public override string ToString()
        {
            return "Mac Checkbox" ;
        }
    }

    class Program
    {
        public static void Main(string[] arg)
        {
            IGUIFactory winFactory = new WinFactory();
            IButton winBtn = winFactory.createButton();
            ICheckBox winCB = winFactory.createCheckbox();

            Console.WriteLine("Windows gui factory results: ");
            Console.WriteLine(winBtn.ToString());
            Console.WriteLine(winCB.ToString());
            Console.WriteLine("---------");

            IGUIFactory macFactory = new MacFactory();
            IButton macBtn = macFactory.createButton();
            ICheckBox macCB = macFactory.createCheckbox();

            Console.WriteLine("Mac gui factory results: ");
            Console.WriteLine(macBtn.ToString());
            Console.WriteLine(macCB.ToString());
            Console.WriteLine("---------");


        }
    }
}
