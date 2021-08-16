using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters.Charachters
{
    public class PrimaryAttribute
    {
        public int Vitality { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        
        // Default constructor is needed for overloading the + operation
        public PrimaryAttribute() {

        }

        // Overloaded constructor
        public PrimaryAttribute(int vitality, int strength, int dexterity, int intelligence)
        {
            Vitality = vitality;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }

        // Overloading the + operator, for making it easier to increase the level
        public static PrimaryAttribute operator + (PrimaryAttribute baseLevel, PrimaryAttribute levelingUp)
        {
            return new PrimaryAttribute()
            {
                Vitality = baseLevel.Vitality + levelingUp.Vitality,
                Strength = baseLevel.Strength + levelingUp.Strength,
                Dexterity = baseLevel.Dexterity + levelingUp.Dexterity,
                Intelligence = baseLevel.Intelligence + levelingUp.Intelligence,
            };
        }
    }
}
