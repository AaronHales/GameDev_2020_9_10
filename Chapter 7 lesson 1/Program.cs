using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chapter_7_lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3 + 5;
            int num2 = 3 - 5;
            //int num3 = (int)(6 / 5.0);
            int num4 = 5 * 5;
            int num5 = 7 % 6;
            Math.Sqrt(43);
            Math.Pow(2, 15);
            Math.Pow(34, 99999999);
            
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            //Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);

            Console.WriteLine(Math.Sqrt(43));

            Console.WriteLine(Math.Pow(2, 10));
            Console.WriteLine(Math.Pow(34, 99999999));

            Console.WriteLine(Math.PI);

            Console.WriteLine(Math.Round(4.18527452451254));
            Console.WriteLine(Math.Abs(-5475186345123));

            Console.WriteLine(Math.Ceiling(55.1));
            Console.WriteLine(Math.Floor(55.9));

            Console.WriteLine(Math.Max(55, 555));
            Console.WriteLine(Math.Min(55, 555));

            Console.WriteLine(Math.Sin(55));
            Console.WriteLine(Math.Cos(555));
            Console.WriteLine(Math.Tan(55));
            Console.WriteLine(Math.Asin(55));
            Console.WriteLine(Math.Acos(555));
            Console.WriteLine(Math.Atan(55));

            Console.WriteLine(Math.E);
            Console.ReadLine();
        }
    }
}
