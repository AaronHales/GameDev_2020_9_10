using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13
{
    class People
    {
        private String skin_color;
        private String eye_color;
        private String hair_color;
        private double hair_length;
        private double lbs;
        private double height;
        private String name;

        public People()
        {
            Console.WriteLine("Enter skin color");
            this.skin_color = Console.ReadLine();
            Console.WriteLine("eye color");
            this.eye_color = Console.ReadLine();
            Console.WriteLine("hair color");
            this.hair_color = Console.ReadLine();
            Console.WriteLine("hair length");
            this.hair_length = Double.Parse(Console.ReadLine());
            Console.WriteLine("lbs");
            this.lbs = Double.Parse(Console.ReadLine());
            Console.WriteLine("height");
            this.height = Double.Parse(Console.ReadLine());
            Console.WriteLine("name");
            this.name = Console.ReadLine();
        }

        public void intro()
        {
            String message;
            message = "Hello, my name is " + this.name + ".";
            message += "\nI have " + this.hair_color + " hair, that is " + this.hair_length + " inches long.";
            message += "\nI have " + this.eye_color + ".";
            message += "\nI have " + this.skin_color + " skin color.";
            message += "\nI am " + this.lbs + " lbs and " + this.height + " inches tall.";
            Console.WriteLine(message);

        }

        public void set_eye_color(String color)
        {
            String password = "up up down down left right left right b a start";
            Console.WriteLine("Enter the password");
            String input = Console.ReadLine();
            if (password == input)
            {
                this.eye_color = color;
            }
            else
            {
                this.eye_color = "n/a";
            }
        }

        public String get_eye_color()
        {
            return this.eye_color;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            People me = new People();
            People you = new People();
            //me.set_eye_color("red");
            //Console.WriteLine("Eye Color: " + me.get_eye_color());
            me.intro();
            you.intro();
            Console.ReadLine();
        }
    }
}
