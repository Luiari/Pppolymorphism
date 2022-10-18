using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pppolymorphism
{
    internal class Tekning
    {
        double Radius;
        double Heigth { get; set; }
        double Base { get; set; }


        public virtual void Area()
        {
            double Area = Heigth * Base;

            Console.WriteLine("Formens area är " + Area);
        }
    }

}
