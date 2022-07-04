using Factory_Method._1_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method._3_Factory
{
    public abstract class ACarFactory
    {
        public abstract ICar GetCar();
    }
}
