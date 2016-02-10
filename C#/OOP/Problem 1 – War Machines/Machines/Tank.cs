using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarMachines.Interfaces;

namespace Problem_1___War_Machines
{
    public class Tank : Mashine, ITank
    {
        public Tank(string name, double attckPoints, 
            double defensePoints)
        {
            this.Name = name;
            this.AttackPoints = attckPoints;
            this.DefensePoints = defensePoints;
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

        public bool DefenseMode { get; private set; }
        public void ToggleDefenseMode()
        {
            throw new NotImplementedException();
        }
    }
}
