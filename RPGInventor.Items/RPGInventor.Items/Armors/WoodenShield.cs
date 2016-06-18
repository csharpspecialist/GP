using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventor.Items.Armors
{
    public class WoodenShield : Item
    {
        public WoodenShield()
        {
            Name = "A Wooden Shield";
            Description = "Splinters";
            Weight = 2;
            Type = ItemType.Armor;
        }
    }
}
