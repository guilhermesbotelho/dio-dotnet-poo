using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_poo_dotnet.src.Entities
{
    public class Wizard : Character
    {
        public Wizard(string Name, int Level, int HealthPoints, int ManaPoints, string WizardType) : base(Name, Level, HealthPoints, ManaPoints)
        {
            this.WizardType = WizardType;
        }
        public string WizardType;

        public string ShowStats()
        {
            return this.GetType().Name + " " + this.Name + " " + this.Level + " " + this.HealthPoints + " " + this.ManaPoints + " " + this.WizardType;
        }
    }
}