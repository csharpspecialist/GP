﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiDi.Items
{
  public  class Ration : IItem
    {
      public void Use()
      {
          Console.WriteLine("Eating a Ration");
      }
    }
}
