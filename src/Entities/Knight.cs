using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_poo_dotnet.src.Entities
{
    public class Knight : Character
    {
        public Knight(string Name, int Level, int HealthPoints, int ManaPoints, string WeaponType) : base(Name, Level, HealthPoints, ManaPoints)
        {
            this.WeaponType = WeaponType;
        }
        public string WeaponType;

        public string ShowStats()
        {
            return this.GetType().Name + " " + this.Name + " " + this.Level + " " + this.HealthPoints + " " + this.ManaPoints + " " + this.WeaponType;
        }
    }
}