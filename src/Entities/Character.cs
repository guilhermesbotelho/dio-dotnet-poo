using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dio_poo_dotnet.src.Entities
{
    public class Character
    {
        public Character(string Name, int Level, int HealthPoints, int ManaPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HealthPoints = HealthPoints;
            this.ManaPoints = ManaPoints;

        }

        public string Name;
        public int Level;
        public int HealthPoints;
        public int ManaPoints;

        public void damage(int Hit){
            if (HealthPoints - Hit > 0 )
            {
                this.HealthPoints -= Hit;
            } 
            else 
            {
                this.HealthPoints = 0;
                Console.WriteLine("You are dead!!");
            }
        }

        public void castSpell(int Spell){
            if (ManaPoints - Spell > 0 )
            {
                this.ManaPoints -= Spell;
            } 
            else 
            {
                Console.WriteLine("You don't have enough mana!! You can't cast a spell.");
            }
        }
    }
}