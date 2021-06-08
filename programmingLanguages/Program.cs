using System;

namespace programmingLanguages
{

    class Client
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with CSharpLanguage factory type...");
            ClientMethod(new CSharpLanguage());
            Console.WriteLine();

            Console.WriteLine("Client: Testing client code with Python factory type...");
            ClientMethod(new PythonLanguage());
        }

        public void ClientMethod(IProgrammingLanguage factory)
        {
            var ProgramLanguageV = factory.CodeVariable();
            var ProgramLanguageM = factory.CodeMethod();
            var ProgramLanguageC = factory.CodeClass();
            var ProgramLanguageL = factory.CodeLambda();

            Console.WriteLine(ProgramLanguageV.BuildVariable());
            Console.WriteLine(ProgramLanguageM.BuildMethod());
            Console.WriteLine(ProgramLanguageC.BuildClass());
            Console.WriteLine(ProgramLanguageL.BuildLambda());
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}


/* The Output of running the program:
 
Client: Testing client code with CSharpLanguage factory type...
..CSharp variable.. |ex: var variable = value; 
..CSharp Method.... |ex: void Method(){}
..CSharp Class..... |ex: class ClassName{}
..CSharp Lambda.... |ex: lambda arguments : expression

Client: Testing client code with Python factory type...
..Python variable.. |ex: variable = value 
..Python Method.... |ex: def void Method(){}
..Python Class..... |ex: class ClassName(){}
..Python Lambda.... |ex: (parameters) => expression
 
 */