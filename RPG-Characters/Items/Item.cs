using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters.Items
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public string EquippingSlot { get; set; }
    }
}
