using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Analysis
{
    public class HeapAllocations
    {
        public void A(List<string> list, string str, int number)
        {
            // FEAT: IEnumerator allocation
            foreach (var s in list) F(s);
            foreach (var s in list.AsEnumerable()) F(s);

            // FEAT: Delegate and Closure allocations
            Action<object> method = F;
            Action lambda = () => F("a");
            Action closure = () => F(str);

            // FEAT: Boxing
            var path = str + '/' + number;
            F(number);
        }

        private void F(object obj)
        {
        }

        private void E(IComparable obj)
        {
        }
    }
}
