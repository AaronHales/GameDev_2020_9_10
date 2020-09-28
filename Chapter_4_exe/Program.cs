using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_exe
{



    enum FishTypes
    {
        Trout,
        Bass,
        Flounder,
        Guppy,
        Carp,
        Tuna
    }


    class Program
    {
        static void Main(string[] args)
        {


            /*
            FishTypes my_fish = FishTypes.Guppy;
            Console.WriteLine(my_fish);
            Console.ReadKey();
            */

            
            
            // whole number data types

            byte var_byte; // stores 1 byte in memory and a number up to 255   examples age, bday (broken into day and month seperately)
            sbyte signed_byte; // stores 1 byte in memory and a number in the range of -128 to 127
            short var_short; // stores 2 bytes in memory and a number in the range of -32,768 to 32,767
            int var_int; // stores 4 bytes in memory and a number between -2,147,483,648 and 2,147,483,647  example distance in inches, hit points, score, cords
            uint var_uint; // stors 4 bytes in memory and a number between 0 and 4,294,967,295
            long var_long; // stores 8 bytes in memory and a number between -9,223,372,036,854,775,808 and 9,223,372,036,854,775,807
            ulong var_ulong; // stores 8 bytes in memory and a number between 0 to 18,446,744,073,709,551,615

            var_byte = 255;
            var_short = 100;
            short answer = (short)((short)var_byte + var_short);
            Console.WriteLine(answer);
            Console.ReadLine();





            //fractional numbers

            float var_float; // stores 4 bytes and a number between -3.4 x 10^38 and +3.4 x 10^38 (with 7 significant digits)
            double var_double; // stores 8 bytes and a number between -1.7 x 10^308 and +1.7 x 10^308 (with 15 - 16 significant digits)
            decimal var_dec; //stores 16 bytes and a number between -7.9 x 10^28 and +7.9 x 10^28 (with 28 - 29 significant digits)

            var_float = 1.02F;
            var_double = 1.92;
            var_dec = 1.02M;

            const double PIE = 3.141592658979;




            int test = (int)(var_double+.5);
            Console.WriteLine(test);
            Console.ReadLine();


            //non numeric data

            char var_char; // stores 2 bytes and one text character
            bool var_bool; // stores 1 byte and true or false

            var_char = 'F';
            var_bool = true;



            /*
            
            int my_int1;
            System.Int32 my_int2;

            Console.WriteLine(System.Int32.MaxValue);
            Console.WriteLine(System.Int32.MinValue);
            Console.ReadKey();
            
            */
        }
    }
}
