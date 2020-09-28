using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4._2_Work_with_Me_test_scores
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare and initialize testScore1 through testScore4 here
            int test_score1 = 85;
            int test_score2 = 92;
            int test_score3 = 100;
            int test_score4 = 80;

            // display each test score
            Console.WriteLine("Test Score 1  = " + test_score1);
            Console.WriteLine("Test Score 2  = " + test_score2);
            Console.WriteLine("Test Score 3  = " + test_score3);
            Console.WriteLine("Test Score 4  = " + test_score4);

            // calcualte the sum and average and display the average
            int sum = test_score1 + test_score2 + test_score3 + test_score4; // adds all the test scores together to get the sum
            
            double average = sum / 4; // divides the sum of test scores by 4 to get average
            Console.WriteLine("AVERAGE SCORE = " + average); // prints average
            Console.ReadLine();
        }
    }
}
