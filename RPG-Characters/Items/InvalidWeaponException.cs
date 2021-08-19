using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters.Items
{
    public class InvalidWeaponException : Exception
    {
        public InvalidWeaponException()
        {
        }
        public InvalidWeaponException(string message) : base(message)
        {
        }
        public override string Message => "Weapon exeption";
    }
}
