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
        public int Level { get; set; }
        public PrimaryAttribute BasePrimaryAttribute { get; set; }
        public PrimaryAttribute TotalPrimaryAttribute { get; set; }
        public SecondaryAttribute SecondaryAttribute { get; set; }

        public Hero()
        {
            Level = 1;
        }

        public Hero(string name)
        {
            Level = 1;
            Name = name;
        }

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
            //sb.AppendLine($"DPS: {SecondaryAttribute.Health}");
            Console.WriteLine(sb);
        }
    }
}
