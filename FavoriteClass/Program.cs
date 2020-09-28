using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their favorite class using a Console.WriteLine() statement
            // Use a Console.ReadLine() statement to get the user's response and save it to a string variable
            // Use a Console.WriteLine() statement to write the response to the screen
            Console.WriteLine("What is your favorite class?"); // asks user what their favorite class is
            Console.WriteLine("Enter your favorite class"); // tells user to enter favorite class
            String favorite_class = Console.ReadLine(); // save enter line as favorite_class
            Console.WriteLine("Your favorite class is: " + favorite_class); // prints favorite class
            Console.ReadKey(); // waits for user to press a key then exits
        }
    }
}
