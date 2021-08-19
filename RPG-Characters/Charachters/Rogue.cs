using RPG_Characters.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPG_Characters.Items.Item;

namespace RPG_Characters.Charachters
{
    public class Rogue : Hero
    {
        // Rogues damageattribute is dexterity
        public double DamageAttribute => (TotalPrimaryAttribute.Dexterity);
        public PrimaryAttribute LevelUpAttribute { get; set; }

        // Overloaded constructor creating a hero with name. Passing the the level 1 primaryattribute statistic and value of the damageattribute.
        // Also creating a LevelUpAttribute, with values what hero gains when leveling up.
        public Rogue(string name) : base(name, new PrimaryAttribute(8, 2, 6, 1), 6)
        {
            LevelUpAttribute = new PrimaryAttribute(3, 1, 4, 1);
        }

        public override void LevelUp()
        {
            HeroLevel += 1;
            BasePrimaryAttribute += LevelUpAttribute;
            TotalPrimaryAttribute += LevelUpAttribute;
            SecondaryAttribute.Update(TotalPrimaryAttribute);
        }

        public override void LevelUp(int levels)
        {
            // Checking that the amount of levels is more than zero
            if (levels > 0)
            {
                HeroLevel += levels;
                BasePrimaryAttribute += LevelUpAttribute * levels;
                TotalPrimaryAttribute += LevelUpAttribute * levels;
                SecondaryAttribute.Update(TotalPrimaryAttribute);
            }
            // If the level is zero or negative exception will be trhown
            else
            {
                throw new ArgumentException("Can't level up 0 or less levels.");
            }
        }

        public override string EquipItem(Armor armor)
        {
            // Checking that the armor is not too high level and it's a correct type one. 
            bool armorlOK = armor.CheckItem(this);

            // If armor is ok for the hero, it will be equipped and primaryattributes and secondaryattributes will be updated
            if (armorlOK)
            {
                Equipments[armor.EquippingSlot] = armor;
                TotalPrimaryAttribute += armor.ArmorAttribute;
                SecondaryAttribute.Update(TotalPrimaryAttribute);
                return "New armor equipped!";
            }
            // If the armor is not ok for the hero exception will be trhown
            else
            {
                throw new InvalidArmorException();
            }
        }

        public override string EquipItem(Weapon weapon)
        {
            // Checking that the weapon is not too high level and it's a correct type one.
            bool weaponOK = weapon.CheckItem(this);

            // If weapon is ok for the hero, it will be equipped to weapon slot and secondaryattributes will be updated
            if (weaponOK)
            {
                Equipments[Slot.Weapon] = weapon;
                SecondaryAttribute.Update(TotalPrimaryAttribute, DamageAttribute, weapon);
                return "New weapon equipped!";
            }
            // If the weapon is not ok for the hero exception will be trhown
            else
            {
                throw new InvalidWeaponException();
            }
        }
    }
}
