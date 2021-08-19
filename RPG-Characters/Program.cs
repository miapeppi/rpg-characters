using RPG_Characters.Charachters;
using RPG_Characters.Items;
using System;
using static RPG_Characters.Items.Armor;
using static RPG_Characters.Items.Item;
using static RPG_Characters.Items.Weapon;

namespace RPG_Characters
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Hey, you. You're finally awake.");
            Console.Write("What's your name? ");
            string name = Console.ReadLine();
            Console.Write($"Tell me {name}, are you a Mage, a Ranger, a Rogue or a Warrior? ");
            string heroType = Console.ReadLine();
            
            
            if(heroType.ToLower() == "mage")
            {
                Mage hero = new Mage(name);
            } 
            else if(heroType.ToLower() == "ranger") {
                Ranger hero = new Ranger(name);
            }
            else if (heroType.ToLower() == "rogue")
            {
                Rogue hero = new Rogue(name);
            }

            else if (heroType.ToLower() == "warrior")
            {
                Warrior hero = new Warrior(name);
            }

            Console.WriteLine($"A {heroType} you say, eh? Well let's have a look at your stats: ");

            hero.PrintCharacterSheet();
            */


            Mage mage = new Mage("Mage");

            Weapon staff = new Weapon()
            {
                ItemName = "Common staff",
                ItemLevel = 4,
                WeaponType = WeaponTypes.Staff,
                WeaponAttribute = new WeaponAttribute() { Damage = 2, AttackSpeed = 5}
            };

            Weapon xstaff = new Weapon()
            {
                ItemName = "Common staff",
                ItemLevel = 4,
                WeaponType = WeaponTypes.Staff,
                WeaponAttribute = new WeaponAttribute() { Damage = 100, AttackSpeed = 15 }
            };


            Armor cloth = new Armor()
            {
                ItemName = "Super cloth",
                ItemLevel = 2,
                EquippingSlot = Slot.Head,
                ArmorType = ArmorTypes.Cloth,
                ArmorAttribute = new PrimaryAttribute( ) { Dexterity = 2, Vitality = 10}
            };


            Armor xcloth = new Armor()
            {
                ItemName = "Super cloth",
                ItemLevel = 2,
                EquippingSlot = Slot.Body,
                ArmorType = ArmorTypes.Cloth,
                ArmorAttribute = new PrimaryAttribute() { Dexterity = 1, Vitality = 1 }
            };

            mage.PrintCharacterSheet();
            mage.LevelUp(5);
            mage.EquipItem(staff);
            mage.PrintCharacterSheet();
            mage.EquipItem(xstaff);
            mage.PrintCharacterSheet();
            mage.EquipItem(cloth);
            mage.PrintCharacterSheet();
            mage.EquipItem(xcloth);
            mage.PrintCharacterSheet();
        }
    }
}
