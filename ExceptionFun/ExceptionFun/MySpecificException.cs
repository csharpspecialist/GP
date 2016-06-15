using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFun
{
     public class MySpecificException : Exception
     {
         public MySpecificException(string Message) : base(Message)
         {
             HelpLink = "http://www.gooogle.com";
         }
     }
}
