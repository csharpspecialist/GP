using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MaskingAndBase
{
   public class DerivedClass : BaseClass
    {
        //masking the base fields
       public string Field1 = "Derived Class Field1";


       public new void PrintField1()
       {
           //writes the derived field
           Console.Write(Field1);

            //writes the base field
           Console.WriteLine(base.Field1);
       }

    }
}
