using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventor.Items.Containers
{
  public  class BackPack : Container

    {
      public BackPack() : base(4)
      {
          Name = "Leather backpack";
          Description = "not too big";
          Weight = 2;

      }
    }
}
