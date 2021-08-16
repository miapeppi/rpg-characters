using RPG_Characters.Charachters;
using System;

namespace RPG_Characters
{
    class Program
    {
        static void Main(string[] args)
        {

            Mage mage = new Mage("Mage");
            mage.PrintCharacterSheet();
            mage.LevelUp();
            mage.PrintCharacterSheet();

        }
    }
}
