using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Editing
{
    public class Selection
    {
        // FEAT: Expand / Shrink Selection
        public void M(IEnumerable<int> numbers)
        {
            var stringBuilder = new StringBuilder();
            foreach (var number in numbers.Where(x => x % 2 == 0).OrderByDescending(x => x).Select(x => Math.Pow(x, 2)))
            {
                stringBuilder
                    .AppendLine("New Line")
                    .AppendLine($"Here comes the number {number}");
            }
        }
    }
}
