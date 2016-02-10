using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarMachines.Interfaces;

namespace Problem_1___War_Machines
{
    public abstract class Mashine:IMachine
    {
        public Mashine(string name, IPilot pilot, double healthPoint, 
            double attckPoints, double defensePoints,IList<string>targets)
        {
            this.Name = name;
            this.Pilot = pilot;
            this.HealthPoints = healthPoint;
            this.AttackPoints = attckPoints;
            this.DefensePoints = defensePoints;
            this.Targets = targets;
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
    }
}
