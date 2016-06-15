using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
   public class Minivan : Car
    {
        //default constructor

       public Minivan() : base(60)
       {
           MaxSpeed = 90;
       }

        //comstructor calling Car(int,int)
       public Minivan(int max, int min) : base(max, min) { }

        //constructor not specifying a base constructor
        //hence, call base Car constructor
        public Minivan(int max) { }

    }


}
