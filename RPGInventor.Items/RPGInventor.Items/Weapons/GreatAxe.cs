using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventor.Items.Weapons
{
   public class GreatAxe : Item
    {
       public GreatAxe()
       {
           Name = "A Great Axe";
           Description = "An Axe, its Great";
           Weight = 5;
           Type = ItemType.Weapon;
       }
    }
}
