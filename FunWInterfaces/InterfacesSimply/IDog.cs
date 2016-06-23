using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesSimply
{
    public interface IDog
    {
        string Name { get; }

        void Bark();
        string GoForAWalk();
    }
}
