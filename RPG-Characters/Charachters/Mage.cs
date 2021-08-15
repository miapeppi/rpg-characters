using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters.Charachters
{
    public class Mage : Hero
    {
        public Mage(): base()
        {
            BasePrimaryAttribute = new PrimaryAttribute(5, 1, 1 , 8);
            TotalPrimaryAttribute = new PrimaryAttribute(5, 1, 1, 8);
            SecondaryAttribute = new SecondaryAttribute(TotalPrimaryAttribute);
        }

        public Mage(string name): base(name)
        {
            BasePrimaryAttribute = new PrimaryAttribute(5, 1, 1, 8);
            TotalPrimaryAttribute = new PrimaryAttribute(5, 1, 1, 8);
            SecondaryAttribute = new SecondaryAttribute(TotalPrimaryAttribute);
        }

        public override void LevelUp()
        {
            throw new NotImplementedException();
        }
    }
}
