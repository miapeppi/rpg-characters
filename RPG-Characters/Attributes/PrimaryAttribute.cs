using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters.Charachters
{
    public class PrimaryAttribute
    {
        public int Vitality { get; set; } = 0;
        public int Strength { get; set; } = 0;
        public int Dexterity { get; set; } = 0;
        public int Intelligence { get; set; } = 0;
        
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

        // Overloading the + operator, to making it easier to increase the level
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

        // Overloading the * operation, to making it to increase multiple levels
        public static PrimaryAttribute operator * (PrimaryAttribute baseLevel, int number)
        {
            return new PrimaryAttribute()
            {
                Vitality = baseLevel.Vitality * number,
                Strength = baseLevel.Strength * number,
                Dexterity = baseLevel.Dexterity * number,
                Intelligence = baseLevel.Intelligence * number
            };
        }
    }
}
