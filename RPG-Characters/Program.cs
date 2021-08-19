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

            Console.WriteLine("Hey, you. You're finally awake.");
            Console.Write("What's your name? ");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.Write($"Tell me {name}, are you a Mage, a Ranger, a Rogue or a Warrior? ");
            string heroType = Console.ReadLine();
            Console.WriteLine();

            Hero hero = null;
            
            if(heroType.ToLower() == "mage")
            {
                hero = new Mage(name);
            } 
            else if(heroType.ToLower() == "ranger") {
                hero = new Ranger(name);
            }
            else if (heroType.ToLower() == "rogue")
            {
                hero = new Rogue(name);
            }

            else if (heroType.ToLower() == "warrior")
            {
                hero = new Warrior(name);
            }
            else
            {
                hero = new Mage(name);
            }

            Console.WriteLine($"A {heroType} you say, eh? Well let's have a look at your stats: ");
            hero.PrintCharacterSheet();

            Console.Write("Would you like to level up? Yes or no? ");
            string answer = Console.ReadLine();
            Console.WriteLine();

            if(answer.ToLower() == "yes")
            {
                Console.Write("Great! How many levels? ");
                int levels = Convert.ToInt32(Console.ReadLine());
                hero.LevelUp(levels);
                Console.WriteLine();
                Console.WriteLine("Here are your new stats: ");
                hero.PrintCharacterSheet();

            } else
            {
                Console.WriteLine("So it's no then.");
            }
        }
    }
}
