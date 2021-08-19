using RPG_Characters.Charachters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters.Items
{
    public class Armor : Item
    {
        // Enums for every armor type that can be equipped
        public enum ArmorTypes
        {
            Cloth,
            Leather,
            Mail,
            Plate
        }
        public ArmorTypes ArmorType { get; set; }
        public PrimaryAttribute ArmorAttribute { get; set; }

        public override bool CheckItem(Hero hero)
        {
            // If the item level is too high, returns false
            if (ItemLevel > hero.HeroLevel)
            {
                return false;
            }
            // If the level of the armor is ok for the hero, starts to check if the armor type is correct
            else
            {
                if (hero.GetType() == typeof(Mage))
                {
                    // If the herotype is mage and armor type is cloth, returns true
                    if (ArmorType == ArmorTypes.Cloth)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (hero.GetType() == typeof(Ranger))
                {
                    // If the herotype is ranger and armor type is leather or mail, returns true
                    if (ArmorType == ArmorTypes.Leather || ArmorType == ArmorTypes.Mail)
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
                    // If the hero type is rogue and armor type is leather or mail, returns true
                    if (ArmorType == ArmorTypes.Leather || ArmorType == ArmorTypes.Mail)
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
                    if (ArmorType == ArmorTypes.Mail || ArmorType == ArmorTypes.Plate)
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
