using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_1
{
    public abstract class Character
    {
        public WeaponBehaviour weaponBehaviour;

        public Character()
        {
        }

        public abstract void display();

        public void fight()
        {
            weaponBehaviour.fight();
        }

        public void setWeapon(WeaponBehaviour wb)
        {
            weaponBehaviour = wb;
        }
    }


}
