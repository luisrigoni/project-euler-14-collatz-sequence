using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1
{
    public static class CollatzGenerator
    {
        public static IEnumerable<ulong> GenerateSequence(int input)
        {
            if (input < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(input));
            }

            var result = (ulong)input;

            while (result != 1)
            {
                yield return result;

                if (result % 2 == 0)
                {
                    result /= 2;
                }
                else
                {
                    result = (3 * result) + 1;
                }
            }

            yield return 1;
        }

        public static int CountSequence(int input)
        {
            return GenerateSequence(input).Count();
        }
    }
}
