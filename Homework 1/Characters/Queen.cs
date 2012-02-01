using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_1
{
    public class Queen : Character
    {
        public Queen()
        {
            weaponBehaviour = new KnifeBehaviour();
        }

        public override void display()
        {
            Console.WriteLine("I'm a queen.");
        }
    }
}
