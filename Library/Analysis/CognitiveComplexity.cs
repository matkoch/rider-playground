using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Library.Analysis
{
    public class CognitiveComplexity
    {
        private static IEnumerable<int> Foo(ICollection<int> numbers)
        {
            foreach (int i in numbers)
            {
                foreach (var j in numbers)
                {
                    foreach (var k in numbers)
                    {
                        yield return i * j * k;
                    }
                }
            }
        }
        private static IEnumerable<int> Bar(ICollection<int> numbers)
        {
            return
                from i in numbers
                from j in numbers
                from k in numbers
                select i * j * k;
        }
    }
}
