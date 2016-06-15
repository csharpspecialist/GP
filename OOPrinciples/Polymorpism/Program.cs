﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorpism
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a point and write it out
            Point p1 = new Point(7,17);
            Console.WriteLine(p1);

            //create another point and write it out
            Point p2 = new Point(7,17);
            Console.WriteLine(p2);
            Console.WriteLine(Object.Equals(p1,p2));
            Console.WriteLine(Object.ReferenceEquals(p1, p2));

            //use our copy method and create a new point and compare

            Point p3 = p1.Copy();
            Console.WriteLine(Object.Equals(p1, p3));
            Console.WriteLine(Object.ReferenceEquals(p1, p3));

            Console.ReadLine();
        }
    }
}
