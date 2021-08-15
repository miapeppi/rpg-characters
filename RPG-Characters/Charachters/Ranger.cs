using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters.Charachters
{
    public class Ranger : Hero
    {
        public Ranger() : base()
        {
            BasePrimaryAttribute = new PrimaryAttribute(8, 1, 7, 1);
            TotalPrimaryAttribute = new PrimaryAttribute(8, 1, 7, 1);
            SecondaryAttribute = new SecondaryAttribute(TotalPrimaryAttribute);
        }
        public Ranger(string name) : base(name)
        {
            BasePrimaryAttribute = new PrimaryAttribute(8, 1, 7, 1);
            TotalPrimaryAttribute = new PrimaryAttribute(8, 1, 7, 1);
            SecondaryAttribute = new SecondaryAttribute(TotalPrimaryAttribute);
        }
        public override void LevelUp()
        {
            throw new NotImplementedException();
        }
    }
}
