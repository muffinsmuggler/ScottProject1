using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Character robert = new Knight();
            Character oscar = new Troll();
            robert.display();
            robert.fight();
            oscar.display();
            oscar.fight();
            robert.setWeapon(new BananaBehaviour());
            robert.fight();


            System.Threading.Thread.Sleep(5000);
        }
    }
}
