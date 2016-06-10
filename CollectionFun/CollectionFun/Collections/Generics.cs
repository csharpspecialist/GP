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


        public void ShowQueue()
        {
            Console.WriteLine("---Generic ShowStack-----");
            Queue<Person> people = new Queue<Person>();

            people.Enqueue(new Person() { FirstName = "Homer", Lastname = "Simpson" });
            people.Enqueue(new Person() { FirstName = "Mildred", Lastname = "Simpson" });

            int count = people.Count;
            Person simpson;

            for (int i = 0; i < count; i++)
            {
                simpson = people.Dequeue();

                Console.WriteLine("Here he is {0}, {1}", simpson.FirstName, simpson.Lastname);
            }



        }

      public void SimpleList()
      {
          Console.WriteLine("--------Simple List -------");

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.AddRange(new int[] {1,2,3,4,5});

            numbers.Insert(2,100);
          foreach (var car in numbers)
          {
              Console.WriteLine(car);
          }
          numbers.Remove(4);

            numbers.RemoveRange(0,2);

            numbers.RemoveAt(0);

      }

      public void PersonDictionary()
      {
            Console.WriteLine("--------Dictionary -------");
            Dictionary<string,Person> people = new Dictionary<string, Person>();

            Person kyrie  = new Person() { FirstName = "Kyrie", Lastname = "Irving" };
            Person mike = new Person() { FirstName = "Mike", Lastname = "Singletary" };

            people.Add(kyrie.Lastname,kyrie);
            people.Add(mike.Lastname, mike);

          foreach (var person in people)
          {
              Console.WriteLine($"{person.}");
          }



        }


    }
}
