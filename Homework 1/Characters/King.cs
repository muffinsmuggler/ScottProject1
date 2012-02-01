using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_1
{
    public class King : Character
    {
        public King()
        {
            weaponBehaviour = new SwordBehaviour();
        }

        public override void display()
        {
            Console.WriteLine("I'm a king.");
        }
    }
}
