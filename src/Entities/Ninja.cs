using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_poo_dotnet.src.Entities
{
    public class Ninja : Character
    {
        public Ninja(string Name, int Level, int HealthPoints, int ManaPoints, string NinjaTool) : base(Name, Level, HealthPoints, ManaPoints)
        {
            this.NinjaTool = NinjaTool;
        }
        public string NinjaTool;

        public string ShowStats()
        {
            return this.GetType().Name + " " + this.Name + " " + this.Level + " " + this.HealthPoints + " " + this.ManaPoints + " " + this.NinjaTool;
        }
    }
}