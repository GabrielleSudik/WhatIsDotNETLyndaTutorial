using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//auto-implemented properties.
//we did last lesson by hand.
//here we will auto-property "health" below.

namespace LearningProperties
{
    class Player
    {
        public bool IsAlive
        {
            get { return Health > 0; }
        }

        //int health = 100; previous variable.

        //step one: "prop TAB TAB"
        //fill in the specifics.
        public int Health { get; private set; } = 100; //step two: you added the 100
            //it serves as a constructor for the property

        //I think creating a property also creates
        //the matching private variable (did I get that right??)
        //maybe that's for auto-implemented props only?

        //step three: make sure all references are to Health not health

        //step four: adjust accessibility of get and set, if needed.
        //here, we will make set private, so only this class can set it.

        public void Hit()
        {
            Random r = new Random();
            Health -= r.Next(5, 50); //set is private, but this is within the same class, so it's ok.
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            for (int i = 0; i < 20; i++)
            {
                player.Hit();
                Console.WriteLine("Is player alive: " + player.IsAlive);
            }
        }
    }
}
