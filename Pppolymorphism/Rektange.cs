using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pppolymorphism
{
    internal class Rektange : Tekning
    {
        double Heigth 
        {
            get { return Heigth; }
            set { Heigth = value; }
        } 

        double Base 
        {
            get { return Base; }
            set { Base = value; }
        }
       

        public Rektange(double Heigth, double Base)
        {
            this.Heigth = Heigth;
            this.Base = Base;

        }
        public override void Area()
        {
            double Area = Heigth * Base;

            Console.WriteLine("Rektangels area är " + Area);
        }

    }
}
