using RPG_Characters.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters.Charachters
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; } = 1; // Every characters level at the begin is 1
        public PrimaryAttribute BasePrimaryAttribute { get; set; }
        public PrimaryAttribute TotalPrimaryAttribute { get; set; }
        public SecondaryAttribute SecondaryAttribute { get; set; }

        // Default constructor 
        public Hero()
        {
            
        }

        // Overloaded constructor creating a new character and adding a name to it
        public Hero(string name)
        {
            Name = name;
        }

        // Abstract method for leveling up, that every subclass inherit
        public abstract void LevelUp();

        public void PrintCharacterSheet()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Character name: {Name}");
            sb.AppendLine($"Character level: {Level}");
            sb.AppendLine($"Strength: {TotalPrimaryAttribute.Strength}");
            sb.AppendLine($"Dexterity: {TotalPrimaryAttribute.Dexterity}");
            sb.AppendLine($"Intelligence: {TotalPrimaryAttribute.Intelligence}");
            sb.AppendLine($"Health: {SecondaryAttribute.Health}");
            sb.AppendLine($"Armor rating: {SecondaryAttribute.ArmorRating}");
            sb.AppendLine($"Elementa resistance: {SecondaryAttribute.ElementalResistance}");
            sb.AppendLine($"DPS: {SecondaryAttribute.Damage}");
            Console.WriteLine(sb);
        }
    }
}
