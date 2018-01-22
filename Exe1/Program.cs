using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1
{
    static class Program
    {
        private const int ONE_MILLION = 1000000;

        static void Main(string[] args)
        {
            var sequencesMeta = (from input in Enumerable.Range(1, ONE_MILLION)
                                 let sequence = CollatzGenerator.GenerateSequence(input)
                                 select new
                                 {
                                     Input = input,
                                     Count = sequence.Count(),
                                 });

            var longestCollatzSequence = sequencesMeta
                .OrderByDescending(seq => seq.Count)
                .First();

            Console.WriteLine($"The longest chain is {longestCollatzSequence.Count} with {longestCollatzSequence.Input} as starting number");
            Console.Read();
        }
    }
}
