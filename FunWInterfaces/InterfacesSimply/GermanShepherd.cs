using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesSimply
{
   public class GermanShepherd :IDog
    {
        public string Name { get; set; }

       public void Bark()
       {
           Console.WriteLine("Woof");
       }

       public string GoForAWalk()
       {
           return "Going for a walk";
       }
    }
}
