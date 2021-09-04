using RPG_Characters.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPG_Characters.Items.Item;

namespace RPG_Characters.Charachters
{
    public abstract class Hero
    {
        public string HeroName { get; set; }
        public int HeroLevel { get; set; } = 1; // Every character's level at the beginning is 1
        public PrimaryAttribute BasePrimaryAttribute { get; set; }
        public PrimaryAttribute TotalPrimaryAttribute { get; set; }
        public SecondaryAttribute SecondaryAttribute { get; set; }
        public Dictionary<Slot, Item> Equipments { get; set; }

        // Overloaded constructor creating a new character with a name and also creating a Equipments Dictionary
        public Hero(string name, PrimaryAttribute primaryAttribute, int damageAttribute)
        {
            HeroName = name;
            BasePrimaryAttribute = primaryAttribute;
            TotalPrimaryAttribute = new PrimaryAttribute() + primaryAttribute;
            SecondaryAttribute = new SecondaryAttribute(TotalPrimaryAttribute, damageAttribute);
            InitializeEquipments();
        }

        /// <summary>
        /// Creating a dictionary with all four slots where items can be equipped.
        /// </summary>
        private void InitializeEquipments()
        {
            Equipments = new Dictionary<Slot, Item>();
            Equipments.Add(Slot.Head, null);
            Equipments.Add(Slot.Body, null);
            Equipments.Add(Slot.Legs, null);
            Equipments.Add(Slot.Weapon, null);
        }

        /// <summary>
        /// Method for for leveling hero up one level and increasing the primary and secondary attributes.
        /// </summary>
        public abstract void LevelUp();

        /// <summary>
        /// Method for leveling up the hero precise amount of levels and increasing the primary and secondary attributes.
        /// </summary>
        /// <param name="levels">The amount of levels which the hero levels up</param>
        /// <exception cref="ArgumentException">If character is leveling up 0 or negative number of levels exception will be thrown.</exception>
        public abstract void LevelUp(int levels);

        /// <summary>
        /// Method for equipping one piece of armor. Checks that the armour level and type are ok to equip.
        /// </summary>
        /// <param name="armor">Armor which will be equipped </param>
        /// <exception cref="InvalidArmorException">If hero tries to equip armour too high level or wrong type.</exception>
        public abstract string EquipItem(Armor armor);

        /// <summary>
        /// Method for equipping a weapon. Checks that the weapon level and type are ok to equip.
        /// </summary>
        /// <param name="weapon">Weapon which will be equipped</param>
        /// <exception cref="InvalidWeaponException">If hero tries to equip weapon too high level or wrong type, exception will be thrown.</exception>
        public abstract string EquipItem(Weapon weapon);

        /// <summary>
        /// Method for printing hero's statistic sheet
        /// </summary>
        public void PrintCharacterSheet()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Character name: {HeroName}");
            sb.AppendLine($"Character level: {HeroLevel}");
            sb.AppendLine($"Strength: {TotalPrimaryAttribute.Strength}");
            sb.AppendLine($"Dexterity: {TotalPrimaryAttribute.Dexterity}");
            sb.AppendLine($"Intelligence: {TotalPrimaryAttribute.Intelligence}");
            sb.AppendLine($"Health: {SecondaryAttribute.Health}");
            sb.AppendLine($"Armor rating: {SecondaryAttribute.ArmorRating}");
            sb.AppendLine($"Elementa resistance: {SecondaryAttribute.ElementalResistance}");
            sb.AppendLine($"DPS: {SecondaryAttribute.DPS}");
            Console.WriteLine(sb);
        }
    }
}
