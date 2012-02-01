using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_1
{
    public class Troll : Character
    {
        public Troll()
        {
            weaponBehaviour = new AxeBehaviour();
        }

        public override void display()
        {
            Console.WriteLine("I'm a troll.");
        }
    }
}
