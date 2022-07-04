using Factory_Method._1_Interface;
using Factory_Method._2_Objects;
using Factory_Method._3_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method._4_SubClasses
{
    public class MarutiFactory : ACarFactory
    {
        public override ICar GetCar()
        {
            return new Maruti();
        }
    }
}
