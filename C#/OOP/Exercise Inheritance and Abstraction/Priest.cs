using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_Inheritance_and_Abstraction
{
    public class Priest : Character,IHeal
    {
        public Priest(int health, int mana, int damage)
            : base(125, 200, 100)
        {
        }
        public override void Attack(Character target)
        {
            this.Mana -= 100;
            target.Health -= this.Damage;
            this.Health += this.Damage/10;
        }

        public void Heal(Character target)
        {
            this.Mana -= 100;
            target.Health += 150;
        }

        public void Heal()
        {
        }
    }
}
