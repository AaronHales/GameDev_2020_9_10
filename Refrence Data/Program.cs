using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrence_Data
{

    class Contact
    {

        public String name;
        public String number;
        public String home_address;
        public String work_address;
        public String email;
        public byte age;

        public void display() // creates a method that will print all info typed inside
        {

            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(work_address);
            Console.WriteLine(home_address);
            Console.WriteLine(email);
            Console.WriteLine(age);

        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            /*
            Contact aaron = new Contact();// creates a new Contact object
            // assign values to Contact object
            aaron.name = "Aaron";
            aaron.number = "(123) 453 - 9871";
            aaron.work_address = "At the End of the Rainbow";
            aaron.home_address = "Somewhere over the Rainbow";
            aaron.age = 17;
            aaron.email = "noyoucant@no.com";


            Contact jojo = new Contact();
            Contact moore = new Contact();

            aaron.display();
            Console.WriteLine(jojo);
            Console.WriteLine(moore);
            

            String my_string = "Any string must be wrapped in \"";
            String my_string2 = "any string must be wrapped in \"";

            Console.WriteLine(my_string.Equals(my_string2, StringComparison.OrdinalIgnoreCase)); // checks to see if one string is equal to another
            //Console.WriteLine(my_string == my_string); // works but my cause errors
            */



            
            // creates alphabet
            String letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String letters2 = "         ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine(letters.Equals(letters2));

            // gets the character at the index/ position of a number starting at 0
            char let1 = letters[0];
            char let2 = letters[0];
            char let3 = letters[17];
            char let4 = letters[14];
            char let5 = letters[13];

            // prints the character at each location
            Console.Write(let1);
            Console.Write(let2);
            Console.Write(let3);
            Console.Write(let4);
            Console.WriteLine(let5);

            // replaces character with the character after ,
            letters = letters.Replace("E", " ");
            Console.WriteLine(letters);

            // creates a sting starting at first number (index) and grabbing the next characters
            Console.WriteLine(letters.Substring(6, 4));

            // gets the index placement of a letter and stores as an int
            int j = letters.IndexOf("J");
            Console.WriteLine(j);

            // finds if a string contains a character, if more than one must be in order like DEF
            Console.WriteLine(letters.Contains("R"));

            // writes character length
            Console.WriteLine(letters2.Length);

            // gets rid of spaces beginning and end string
            letters2 = letters2.Trim();
            Console.WriteLine(letters2.Length);


            String empty =  ""; // there is a something
            String nullstr = null; // there is nothing stored


            // waits for user to push enter
            Console.ReadLine();

        }
    }
}
