using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_Inheritance_and_Abstraction
{
    public abstract class Character:IAttack
    {
        private int health;
        private int mana;
        private int damage;
        public Character(int health, int mana, int damage)
        {
            this.Health = health;
            this.Mana = mana;
            this.Damage = damage;
        }
        public int Damage { get; set; }

        public int Mana { get; set; }

        public int Health { get; set; }

        public void Attack()
        {        
        }
        public abstract void Attack(Character target);
    }
}
