using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFun.Collections
{
  public class Generics
    {
      public void showStack()
      {
          Console.WriteLine("---Generic ShowStack-----");
            Stack<Person> people = new Stack<Person>();

            people.Push(new Person() {FirstName = "Homer", Lastname = "Simpson"});
            people.Push(new Person() { FirstName = "Mildred", Lastname = "Simpson" });

          int count = people.Count;
          Person simpson;

          for (int i = 0; i < count; i++)
          {
              simpson = people.Pop();

              Console.WriteLine("Here he is {0}, {1}",simpson.FirstName,simpson.Lastname);
          }



      }
    }
}
