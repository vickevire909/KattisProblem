using System;
using System.Collections.Generic;
using System.Linq;

namespace KattisCsharp
{
    public class Row
    {
        public int T;
        public char Z;

        public Row(string input)
        {
            T = Convert.ToInt32(input.Split().First());
            Z = input.Split().Last().ToCharArray().FirstOrDefault();
        }
    }

    public class Volim
    {
        public static void VolimP()
        {
            int time = 0;
            int totalTime = 210;
            List<Row> rows = new List<Row>();
            int K = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < N)
            {
                rows.Add(new Row(Console.ReadLine()));
                i++;
            }
            foreach (Row row in rows)
            {
                time += row.T;
                if (time > totalTime)
                {
                    break;
                }
                if (row.Z == 'T')
                {
                    K++;
                }
            }
            K = ((K - 1) % 8) + 1;
            Console.WriteLine(K);
        }
    }
}
