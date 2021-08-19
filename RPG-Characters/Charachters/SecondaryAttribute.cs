using RPG_Characters.Items;
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
        public double DPS { get; set; }

        // Overloaded constructor calculating DPS with no weapon equippd
        public SecondaryAttribute(PrimaryAttribute totalAtribute, double damageAttribute)
        {
            Health = totalAtribute.Vitality * 10;
            ArmorRating = totalAtribute.Strength + totalAtribute.Dexterity;
            ElementalResistance = totalAtribute.Intelligence;
            DPS = 1 * (double)(1 + (damageAttribute / 100));
        }

        /// <summary>
        /// Method to uppdate secondaryattributes when there is changes in the primaryattributes
        /// </summary>
        /// <param name="totalAtribute">Updated totalattributes with e.g. new armor added</param>
        public void Update(PrimaryAttribute totalAtribute)
        {
            Health = totalAtribute.Vitality * 10;
            ArmorRating = totalAtribute.Strength + totalAtribute.Dexterity;
            ElementalResistance = totalAtribute.Intelligence;
        }

        /// <summary>
        /// Method to uppdate secondaryattributes when there is new weapon equipped
        /// </summary>
        /// <param name="totalAtribute">Updated totalattributes</param>
        /// <param name="damageAttribute">Heros damageattribute</param>
        /// <param name="weapon">Weapon what have been added</param>
        public void Update(PrimaryAttribute totalAtribute, double damageAttribute, Weapon weapon)
        {
            Health = totalAtribute.Vitality * 10;
            ArmorRating = totalAtribute.Strength + totalAtribute.Dexterity;
            ElementalResistance = totalAtribute.Intelligence;
            DPS = weapon.WeaponAttribute.DPS * (double)(1 + (damageAttribute / 100));
        }
    }
}
