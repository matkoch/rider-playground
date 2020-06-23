using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Analysis
{
    public class MultipleEnumeration
    {
        // FEAT: [Inspection] Possible multiple enumeration
        public void M(IEnumerable<string> strings)
        {
            foreach (var s in strings) F(s);
            foreach (var s in strings) F(new string(s.Reverse().ToArray()));
        }

        // FEAT: [Inspection] Multiple sequential OrderBy
        public IEnumerable<string> N(IEnumerable<string> strings)
        {
            return strings
                .OrderByDescending(x => x.Length)
                .OrderByDescending(x => x, StringComparer.OrdinalIgnoreCase);
        }

        public void F(string s)
        {
        }
    }
}
