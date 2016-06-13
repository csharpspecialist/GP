using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndPartials
{
    public partial class Player
    {
        //properties
        public string Name { get; set; }
        public int Score { get; set; }

        //default consructor without a parameter
        public Player()
        {
            Name = "New Player";
        }

      
    }

}
