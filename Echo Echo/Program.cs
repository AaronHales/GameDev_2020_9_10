using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo_Echo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type your name and press Enter: ");
            String user_name = Console.ReadLine();
            Console.WriteLine("Hello " + user_name);
            Console.WriteLine("Press any key to leave");
            Console.ReadKey();
        }
    }
}
