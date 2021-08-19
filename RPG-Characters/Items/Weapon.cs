using RPG_Characters.Charachters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters.Items
{
    public class Weapon : Item
    {
        // Enums for every weapon type that can be equipped
        public enum WeaponTypes
        {
            Axe,
            Bow,
            Dagger,
            Hammer,
            Staff,
            Sword,
            Wand
        }
        public WeaponTypes WeaponType { get; set; }
        public WeaponAttribute WeaponAttribute { get; set; }

        // Constructor that creates new weapon attributes and put the equipping slot as a weapon
        public Weapon() : base()
        {
            WeaponAttribute = new WeaponAttribute();
            EquippingSlot = Slot.Weapon;
        }

        public override bool CheckItem(Hero hero)
        {
            // If the item level is too high, returns false
            if (ItemLevel > hero.HeroLevel)
            {
                return false;
            }
            // If the level of the weapon is ok for the hero, starts to check if the weapon type is correct
            else
            {
                if (hero.GetType() == typeof(Mage))
                {
                    // If the herotype is mage and weapon type is staff or wand, returns true
                    if (WeaponType == Weapon.WeaponTypes.Staff || WeaponType == Weapon.WeaponTypes.Wand)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if(hero.GetType() == typeof(Ranger))
                {
                    // If the herotype is ranger and weapon type is bow, returns true
                    if (WeaponType == WeaponTypes.Bow)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (hero.GetType() == typeof(Rogue))
                {
                    // If the hero type is rogue and weapon type is dagger or sword, returns true
                    if (WeaponType == Weapon.WeaponTypes.Dagger || WeaponType == Weapon.WeaponTypes.Sword)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (hero.GetType() == typeof(Warrior))
                {
                    // If the hero type is warrior and he weapon type is axe, hammer or sword, returns true
                    if (WeaponType == Weapon.WeaponTypes.Axe || WeaponType == Weapon.WeaponTypes.Hammer || WeaponType == Weapon.WeaponTypes.Sword)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
               return false;
            }
        }
    }
}
