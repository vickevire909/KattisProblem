using System;
using System.Collections.Generic;
using System.Linq;

namespace KattisCsharp
{
    public class DpDay
    {
        public int day;
        public bool cleaned;

        public DpDay(string day, bool cleaned)
        {
            this.day = Convert.ToInt32(day);
            this.cleaned = cleaned;
        }
    }

    class CodeCleanups
    {
        public static void CodeCleanupsP()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<DpDay> dpDays = Console.ReadLine().Split().Select(x => new DpDay(x, false)).ToList();
            int curDay = dpDays.Select(x => x.day).ToArray().Min();
            int sumOfDirt = 0;
            int cleanCtr = 0;

            while (curDay <= 366)
            {
                sumOfDirt = 0;
                foreach (DpDay dpDay in dpDays.Where(d => d.day <= curDay && !d.cleaned))
                {
                    sumOfDirt += (curDay - dpDay.day);
                }
                if (sumOfDirt >= 20)
                {
                    curDay--;
                    cleanCtr++;
                    foreach (DpDay dpDay in dpDays.Where(d => d.day <= curDay))
                    {
                        dpDay.cleaned = true;
                    }
                }
                if (curDay == 366)
                {
                    if (sumOfDirt > 0)
                    {
                        cleanCtr++;
                    }
                }
                curDay++;
            }
            Console.WriteLine(cleanCtr);
        }
    }
}
