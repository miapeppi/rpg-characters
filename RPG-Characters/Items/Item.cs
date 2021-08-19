using RPG_Characters.Charachters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters.Items
{
    public abstract class Item
    {
        // Enums for every slot that can be equipped
        public enum Slot
        {
            Head,
            Body,
            Legs,
            Weapon
        }
        public string ItemName { get; set; }
        public int ItemLevel { get; set; } = 1;
        public Slot EquippingSlot { get; set; }

        /// <summary>
        /// Method that the armor or weapon is not too high level and that t he item is a correct type for the character
        /// </summary>
        /// <param name="hero">Hero who tries to equipp the item</param>
        /// <returns>True if the item is ok to equipp for the hero, and false if there is some issues with either level or type.</returns>
        public abstract bool CheckItem(Hero hero);
    }
}
