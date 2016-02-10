using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Battleships.Ships;

namespace _02.Using_Polymorphism
{
    public abstract class Battleship 
        : Ship,IAttack
    {
        public Battleship()
        {
            
        }
        public void Attack(Ship targetShip)
        {

        }
    }
}
