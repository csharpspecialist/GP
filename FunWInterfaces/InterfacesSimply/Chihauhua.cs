using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesSimply
{
    public class Chihauhua :IDog

    {
        public string Name { get; private set; }

        public Chihauhua(string name)
        {
            Name = name;
        }

        public void Bark()
        {
            Console.WriteLine("Yip");
        }

        public string GoForAWalk()
        {
            return "Going for short walk";
        }
    }
}
