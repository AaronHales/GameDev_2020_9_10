using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            My_car car1 = new My_car();
            My_car car2 = new My_car();
            Console.WriteLine(car1.color);
            Console.WriteLine(car2.color);
            car1.drive();
            Console.ReadLine();
        }
    }

    class My_car
    {
        public String color;
        private String brand;
        private String make;
        private String model;
        private int year;
        private int mileage;
        public double price;
        Engine engine = new Engine();

        public My_car()
        {
            Console.WriteLine("What color: ");
            color = Console.ReadLine();

            //Console.WriteLine("What brand: ");
        }

        public void drive()
        {
            if (engine.pistons == 8)
            {
                Console.WriteLine("I'm driving really fast");
            }
            else
            {
                Console.WriteLine("I'm driving");
            }
        }

    }

    class Engine
    {
        private String style;
        public int pistons;

        public Engine()
        {
            style = "V";
            pistons = 8;
        }
    }
}
