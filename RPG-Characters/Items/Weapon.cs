using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters.Items
{
    public enum WeaponType
    {
        Axe,
        Bow,
        Dagger,
        Hammer,
        Staff,
        Sword,
        Wand
    }
    public class Weapon : Item
    {
        public WeaponType WeaponType { get; set; }
        public int BaseDamage { get; set; }
        public int AttackSpeed { get; set; }
        public int DPS { get; set; }
    }
}
