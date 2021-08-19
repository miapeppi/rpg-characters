using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters.Items
{
    public class WeaponAttribute
    {
        public int Damage { get; set; } = 1;
        public double AttackSpeed { get; set; } = 1;
        public double DPS => (Damage * AttackSpeed);
    }
}
