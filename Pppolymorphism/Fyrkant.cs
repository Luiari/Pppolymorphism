using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pppolymorphism
{
    internal class Fyrkant:Tekning
    {
        public int Heigth 
        {
            get { return Heigth; }
            set { Heigth = value; }
        }

        int Base 
        {
            get { return Base; }
            set { Base = value; }
        }
       



        public Fyrkant(int Heigth, int Base)
        {


            this.Heigth = Heigth;
            this.Base = Base;
        }
        public override void Area()
        {
            int Area = Heigth * Base;

            Console.WriteLine("Fyrkantens area är " + Area);
        }
    }
}

