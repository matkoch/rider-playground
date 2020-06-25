using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Analysis
{
    public partial class CSharp8
    {
        // FEAT: Index From End Expression
        public T GetPreviousLastElement<T>(T[] array)
        {
            return array[array.Length - 2];
        }

        // FEAT: Async Disposable + Using Declaration + Async Overloads
        public void N(string path, string content) // make async
        {
            using (var stream = new FileStream(path, FileMode.Open))
            using (var writer = new StreamWriter(stream))
            {
                writer.WriteLine(content);
            }
        }

        // FEAT: Async Streams passing cancellation token
        public async Task M(IAsyncEnumerable<int> numbers, CancellationToken token)
        {
            await foreach (var number in numbers) Console.WriteLine(number);
            await foreach (var data in ReadNumbers()) Console.WriteLine(data);
        }

        private async IAsyncEnumerable<int> ReadNumbers([EnumeratorCancellation] CancellationToken token = default)
        {
            await Task.Delay(1000);
            yield return 1;
        }
    }
}
