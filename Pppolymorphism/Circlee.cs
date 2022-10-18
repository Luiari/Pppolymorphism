using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pppolymorphism
{
    internal class Circlee:Tekning
    {
        double Radius;
        public float Pi = 3.141f;
        public Circlee(double Radius)
        {

            this.Radius = Radius;
        }
        public override void Area()
        {
            double circumarea = Radius * Radius * Pi;
            Console.WriteLine("Circelns area är " + circumarea);
        }




    }
}
