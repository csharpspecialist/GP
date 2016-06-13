using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndPartials
{
    public partial class Player
    {
        //consructor w a parameter which is set
        //to Player X from line 13 of Program.cs
        public Player(string Name)
        {
            this.Name = Name;
        }
    }
}
