using System;
using System.Collections.Generic;

namespace Library.Analysis
{
    public class PatternMatching
    {
        public Dictionary<string, List<Func<string, string, string>>> Dictionary
            = new Dictionary<string, List<Func<string, string, string>>>();

        public string Foo(char c)
        {
            if (c >= 'A' && c <= 'Z')
                return "upper-case";
            else if (c >= 'a' && c <= 'z')
                return "lower-case";
            else
                return "what case?";
        }

        public void Check(string str)
        {
        }
    }
}
