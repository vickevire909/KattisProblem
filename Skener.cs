using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KattisCsharp
{
    public class Skener
    {
        public static void RunSkener()
        {
            int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int row = input[0];
            int col = input[1];
            int zrow = input[2];
            int zcol = input[3];

            List<StringBuilder> bobList = new List<StringBuilder>();
            for (int i = 0; i < col; i++)
            {
                var inStr = Console.ReadLine();
                var bob = new StringBuilder();
                foreach (char n in inStr)
                {
                    bob.Append(n, zcol);
                }
                bobList.Add(bob);
            }
            var outRows = bobList.SelectMany(x => Enumerable.Repeat(x, zrow)).ToList();
            foreach (var e in outRows)
            {
                Console.WriteLine(e);
            }
        }
    }
}
