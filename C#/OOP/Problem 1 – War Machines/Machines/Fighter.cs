using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarMachines.Interfaces;

namespace Problem_1___War_Machines
{
    public class Fighter : Mashine, IFighter
    {
        public Fighter(string name, IPilot pilot, double healthPoint,
            double attckPoints, double defensePoints, IList<string> targets)          
        {
        }

        public string Name { get; set; }
        public IPilot Pilot { get; set; }
        public double HealthPoints { get; set; }
        public double AttackPoints { get; private set; }
        public double DefensePoints { get; private set; }
        public IList<string> Targets { get; private set; }
        public void Attack(string target)
        {
            throw new NotImplementedException();
        }

        public bool StealthMode { get; private set; }
        public void ToggleStealthMode()
        {
            throw new NotImplementedException();
        }
    }
}
