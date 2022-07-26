using System;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Month = DateTime.Now.Month;
            int Year = DateTime.Now.Year;

            DateTime date = new DateTime(Year, Month, 1);

            int Count = 0;

            while (true)
            {
                if (date.DayOfWeek == DayOfWeek.Monday)
                {
                    Count++;
                }
                date = date.AddDays(1.0);
                if (date.Month != Month)
                {
                    break;
                }
            }

            Console.WriteLine("Кол-во понедельников в текущем месяце: {0}", Count);
            Console.ReadKey();
        }

    }
}