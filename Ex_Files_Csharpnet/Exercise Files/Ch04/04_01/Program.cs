using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//PROPERTIES
//A property is a member that
//provides a mechanism to read, write and compute
//the value of a private field
//they can seem like public variables but
//they are more like functions because
//they contain special methods. Get and Set.

namespace LearningProperties
{
    class Player
    {
        //this is an example of a public variable:
        //public bool IsAlive = true;

        //here it is as a property instead:
        //PascalCase is standard for properties
        public bool IsAlive
            {
             get {return health > 0; } //returns true if health is > 0.
            }
        //note because there is no setter, this property is protected
        //if it were a public variable, someone could set it.

        int health = 100;

        public void Hit()
        {
            Random r = new Random();
            health -= r.Next(5, 50);
        }

        //if we didn't have the Get method inside the IsAlive property,
        //we'd need a method like this.
        //but because the property checks for health > 0
        //we don't need this.
        //public void CheckDeath()
        //{
        //    if (health <= 0)
        //        isAlive = false;
        //}
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
