using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarMachines.Interfaces;

namespace Problem_1___War_Machines
{
    public class Pilot:IPilot
    {
        public Pilot(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
        public void AddMachine(IMachine machine)
        {
            
        }

        public string Report()
        {
        }
    }
}
