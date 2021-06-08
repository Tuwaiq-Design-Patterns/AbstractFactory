using System;
namespace programmingLanguages
{
    /*The abstract factory interface*/
    public interface IProgrammingLanguage
    {   

        IVariable CodeVariable();
        IMethod CodeMethod();
        IClass CodeClass();
        ILambda CodeLambda();
    }


    /*The concrete factories*/

    class CSharpLanguage : IProgrammingLanguage
    {
        public IVariable CodeVariable()
        {
            return new CSharpVariable();
        }

        public IMethod CodeMethod()
        {
            return new CSharpMethod();
        }

        public IClass CodeClass()
        {
            return new CSharpClass();
        }

        public ILambda CodeLambda()
        {
            return new CSharpLambda();
        }
    }

    // ------------------------------------------------------
    class PythonLanguage : IProgrammingLanguage
    {
        public IVariable CodeVariable()
        {
            return new PythonVariable();
        }

        public IMethod CodeMethod()
        {
            return new PythonMethod();
        }

        public IClass CodeClass()
        {
            return new PythonClass();
        }

        public ILambda CodeLambda()
        {
            return new PythonLambda();
        }
    }
}
