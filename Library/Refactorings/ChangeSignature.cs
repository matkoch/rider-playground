using System;

namespace Library.Refactorings
{
    public class ChangeSignature
    {
        public ChangeSignature(Type type1)
        {
            myType = type1;
        }

        private Type myType;

        public void A(Type type)
        {
            B("best", false, myType);
            B("nice", false, type);
            B("test", false, null);
        }

        public void B(string value, bool flag, Type type)
        {
            Console.WriteLine(value);
        }
    }
}