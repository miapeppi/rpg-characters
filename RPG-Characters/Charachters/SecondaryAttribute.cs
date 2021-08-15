using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters.Charachters
{
    public class SecondaryAttribute
    {
        public int Health { get; set; }
        public int ArmorRating { get; set; }
        public int ElementalResistance { get; set; }
        public int Damage { get; set; }

        public SecondaryAttribute(PrimaryAttribute totalAtribute)
        {
            Health = totalAtribute.Vitality * 10;
            ArmorRating = totalAtribute.Strength + totalAtribute.Dexterity;
            ElementalResistance = totalAtribute.Intelligence;
 
        }
    }
}
