using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFun.Collections
{
    public class NonGenerics
    {
        public  static void ShowArrayList()
        {
            Console.WriteLine("--Show array List----");

            ArrayList arrayList = new ArrayList();

            arrayList.Add("Hello");
            arrayList.Add(17);

            Person p = new Person();
            p.FirstName = "Dude";
            p.Lastname = "Girlmagnet";

            arrayList.Add(p);

            foreach (object o in arrayList)
            {
                Console.WriteLine(o);
            }

        }


        public static void ShowHashTable()
        {
            //hashtables don't display in any order at all!!!
            Hashtable map = new Hashtable();

            map.Add(1,"Hello");
            map.Add("Working",2);
            map.Add(true,123.334);

            Person bart = new Person();
            bart.FirstName = "Bart";
            bart.Lastname = "Simpson";

            map.Add(bart.Lastname, bart);

            foreach (var key in map.Keys)
            {
                Console.WriteLine($"{key} = {map[key]}");
            }


        }

        public static void ShowQueue()
        {
            Console.WriteLine("-----Showing Queue----");
            Queue myQueue = new Queue();

            myQueue.Enqueue("Hello");
            myQueue.Enqueue(123);

            Person kyrie = new Person();

            kyrie.FirstName = "Kyrie";
            kyrie.Lastname = "Irving";

            myQueue.Enqueue(kyrie);

            int count = myQueue.Count;
            for (int c = 0; c < count; c++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
        }

        public static void ShowStack()
        {
            Console.WriteLine("-----Showing Stack----");
            Stack myStack = new Stack();

            myStack.Push("Hello");
            myStack.Push(123);

            Person kyrie = new Person();

            kyrie.FirstName = "Kyrie";
            kyrie.Lastname = "Irving";

            myStack.Push(kyrie);

            int count = myStack.Count;
            for (int c = 0; c < count; c++)
            {
                Console.WriteLine(myStack.Pop());
            }
        }



    }


}
