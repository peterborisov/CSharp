using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_Inheritance_and_Abstraction
{
    public class Warrior : Character
    {
        public Warrior(int health, int mana, int damage) 
            : base(300, 0, 120)
        {
        }
        public override void Attack(Character target)
        {
        }
    }
}
