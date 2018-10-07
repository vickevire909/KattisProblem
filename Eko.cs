using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KattisCsharp
{
    class Eko
    {
        public static void EkoP()
        {
            long[] line1 = Console.ReadLine().Split().Select(x => Convert.ToInt64(x)).ToArray();
            long N = line1[0];
            long M = line1[1];
            long[] array = Console.ReadLine().Split().Select(x => Convert.ToInt64(x)).ToArray();
            long max = array.Max();
            long h = 0;
            long beg;
            long end, mid;
            long cutted;

            beg = 0;
            end = max;
            while (beg <= end)
            {
                mid = (beg + end) / 2;
                cutted = 0;
                for (long i = 0; i < N; ++i)
                {
                    if (array[i] - mid > 0)
                    {
                        cutted += array[i] - mid;
                    }
                }
                if (cutted > M)
                {
                    beg = mid + 1;
                    if (mid > h)
                    {
                        h = mid;
                    }
                }
                else if (cutted < M)
                {
                    end = mid - 1;
                }
                else
                {
                    h = mid;
                    break;
                }
            }
            Console.WriteLine(h);
        }
    }
}
