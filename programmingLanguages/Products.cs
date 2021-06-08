using System;
namespace programmingLanguages
{

    /* Products with thiers Concrete Products*/

    public interface IVariable
    {
        string BuildVariable();
    }

    class CSharpVariable : IVariable
    {
        public string BuildVariable()
        {
            return "..CSharp variable.. |ex: var variable = value; ";
        }
    }

    class PythonVariable : IVariable
    {
        public string BuildVariable()
        {
            return "..Python variable.. |ex: variable = value ";
        }
    }

    // ------------------------------------------------------
    public interface IMethod
    {
        string BuildMethod();
    }

    class CSharpMethod : IMethod
    {
        public string BuildMethod()
        {
            return "..CSharp Method.... |ex: void Method(){}";
        }
    }

    class PythonMethod : IMethod
    {
        public string BuildMethod()
        {
            return "..Python Method.... |ex: def void Method(){}";
        }
    }


    // ------------------------------------------------------
    public interface IClass
    {
        string BuildClass();
    }

    class CSharpClass : IClass
    {
        public string BuildClass()
        {
            return "..CSharp Class..... |ex: class ClassName{}";
        }
    }

    class PythonClass : IClass
    {
        public string BuildClass()
        {
            return "..Python Class..... |ex: class ClassName(){}";
        }
    }
    // ------------------------------------------------------

    public interface ILambda
    {
        string BuildLambda();
    }


    class CSharpLambda : ILambda
    {
        public string BuildLambda()
        {
            return "..CSharp Lambda.... |ex: lambda arguments : expression";
        }
    }


    class PythonLambda : ILambda
    {
        public string BuildLambda()
        {
            return "..Python Lambda.... |ex: (parameters) => expression";
        }
    }
}
