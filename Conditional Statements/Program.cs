using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {

            /*

            Console.WriteLine(1 < 2); // less than
            Console.WriteLine(1 > 2); // greater than
            Console.WriteLine(1 < 1);

            Console.WriteLine(1 <= 2);
            Console.WriteLine(1 >= 2); // greater then or equal to
            Console.WriteLine(1 <= 1); // less than or equal to

            Console.WriteLine(1 == 1); // equall to
            Console.WriteLine(1 != 1); // ! is a not equal operator

            */


            bool result1 = 52 > 40;
            bool result2 = -3.14159 < 1.732;

            String name = "";

            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("This is true);
            }
            else
            {
                Console.WriteLine("Why did you think it was true");
            }

            Console.ReadLine();

        }
    }
}
