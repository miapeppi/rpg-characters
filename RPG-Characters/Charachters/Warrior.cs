using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters.Charachters
{
    public class Warrior : Hero
    {
        public Warrior() : base()
        {
            BasePrimaryAttribute = new PrimaryAttribute(10, 5, 2, 1);
            TotalPrimaryAttribute = new PrimaryAttribute(10, 5, 2, 1);
            SecondaryAttribute = new SecondaryAttribute(TotalPrimaryAttribute);
        }
        public Warrior(string name) : base(name)
        {
            BasePrimaryAttribute = new PrimaryAttribute(10, 5, 2, 1);
            TotalPrimaryAttribute = new PrimaryAttribute(10, 5, 2, 1);
            SecondaryAttribute = new SecondaryAttribute(TotalPrimaryAttribute);
        }
        public override void LevelUp()
        {
            throw new NotImplementedException();
        }
    }
}
