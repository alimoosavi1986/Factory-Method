using Factory_Method._1_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method._2_Objects
{
    public class Maruti : ICar
    {
        public string GetOnRoadPrice(string model)
        {
            //Logic to get OnRoadPrice based on model 

            if (model == "Alto 800 VXI")

            {
                return "3.4 Lakhs INR";
            }
            else
            {
                return "Information not available!";
            }
        }
    }
}
