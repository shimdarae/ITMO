using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace friday
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(1918, 2, 15);
            DateTime date2 = new DateTime(2167, 1, 1);
            int i = 0;
            while (date1.CompareTo(date2) <= 0)
            { 
                string date = date1.DayOfWeek.ToString();
                int day = date1.Day;
                if (date == "Friday" & day == 13)
                {
                    
                    i = i + 1;
                    Console.WriteLine(date1);
                }
                date1 = date1.AddDays(1);
            }
            Console.WriteLine("Всего пятниц: {0}", i);
            Console.ReadKey();
        }
    }
}
 