using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polymorpism
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"Point as ({x},{y})";
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
             Point otherPoint = (Point)  obj;
        {
            return(this.x == otherPoint.x) && (this.y == otherPoint.y);
        }



}

        public Point Copy()
        {
            return (Point) this.MemberwiseClone();
        }

        
    }
}
