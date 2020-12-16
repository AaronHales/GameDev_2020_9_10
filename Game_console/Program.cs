using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Weapon
    {
        protected double damage;
        protected double range;
        private double rate_of_fire;
        private int acu;
        public String model;

        public double getRate_of_fire()
        {
            return this.rate_of_fire;
        }
        public void setRate_of_fire(double rof)
        {
            if (this.model.Equals("gun"))
            {
                this.rate_of_fire = rof;
            }
        }
        public int getAcu()
        {
            return this.acu;
        }
        public void setAcu(int acu)
        {
            this.acu = acu;
        }
    }

    public class Clip
    {
        private int ammocap;
        private int current_ammo;

        public void setCurrent_ammo(int ammo)
        {
            this.current_ammo += ammo;
        }
    }

    public class Knife : Weapon
    {

        public Knife()
        {
            Console.WriteLine("Used default constructor");
        }
        public Knife(double rof, int acu)
        {
            setRate_of_fire(rof);
            setAcu(acu);

        }
        public Knife(double rof, int acu, String model, double damage, double range)
        {
            setRate_of_fire(rof);
            setAcu(acu);

        }

    }
    public class Gun : Weapon
    {
        Clip clip = new Clip();
        Player target;
        public Gun()
        {
            this.damage = 50;
            this.range = 100;

        }
        public void pull_trigger()
        {
            clip.setCurrent_ammo(-1);
            target.takedamage();
        }
        public void setTarget(Player target)
        {
            this.target = target;
        }

    }

    class Player
    {
        Gun handgun = new Gun();
        int health = 100;
        public Player target;

        public void shoot()
        {
            handgun.pull_trigger();
        }
        public void takedamage()
        {
            this.health--;
        }
        public void setTarget(Player target)
        {
            this.target = target;
        }
    }

    public class PlayGame
    {
        public PlayGame()
        {
            Gun handgun = new Gun();
            Knife knife1 = new Knife();
            Knife knife2 = new Knife(25.5, 55);
            Knife knife3 = new Knife(50, 25, "K Bar", 100.5, 25.0);
        }
        public static void main(String[] args)
        {
            new PlayGame();
        }
    }
}
