using RPG_Characters.Charachters;
using System;

namespace RPG_Characters
{
    class Program
    {
        static void Main(string[] args)
        {

            Mage Peppi = new Mage("Peppi");
            Warrior Anton = new Warrior();
            Anton.Name = "Anton";
            Peppi.PrintCharacterSheet();
            Anton.PrintCharacterSheet();

        }
    }
}
