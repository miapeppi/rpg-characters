using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters.Charachters
{
    public class Rogue : Hero
    {
        public Rogue() : base()
        {
            BasePrimaryAttribute = new PrimaryAttribute(8, 2, 6, 1);
            TotalPrimaryAttribute = new PrimaryAttribute(8, 2, 6, 1);
            SecondaryAttribute = new SecondaryAttribute(TotalPrimaryAttribute);
        }
        public Rogue(string name) : base(name)
        {
            BasePrimaryAttribute = new PrimaryAttribute(8, 2, 6, 1);
            TotalPrimaryAttribute = new PrimaryAttribute(8, 2, 6, 1);
            SecondaryAttribute = new SecondaryAttribute(TotalPrimaryAttribute);
        }
        public override void LevelUp()
        {
            throw new NotImplementedException();
        }
    }
}
