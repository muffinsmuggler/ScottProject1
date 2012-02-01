using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_1
{
    public class Knight : Character
    {
        public Knight()
        {
            weaponBehaviour = new BowAndArrowBehaviour();
        }

        public override void display()
        {
            Console.WriteLine("I'm a knight.");
        }
    }
}
