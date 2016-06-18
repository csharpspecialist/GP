using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventor.Items.Containers
{
    public class PotionSatchel : SpecificContainer
    {
        public PotionSatchel() : base(3,ItemType.Potion)
        {
            Name = "A Potion Satchel";
            Description = "A Satchel that holds potions";
            Weight = 1;

        }
    }
  
}
