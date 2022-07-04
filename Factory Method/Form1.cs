using Factory_Method._1_Interface;
using Factory_Method._3_Factory;
using Factory_Method._4_SubClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Client side
            listBox1.Items.Add("Factory method pattern demo");
            ACarFactory carFactory = null;
            ICar car = null;
            string model = null;

            //Maruti 
            carFactory = new MarutiFactory();
            car = carFactory.GetCar();

            model = "Alto 800 VXI";
            listBox1.Items.Add(
                string.Format(
                    "On-road price for {0} car is: {1} ", model, car.GetOnRoadPrice(model)
                    )
                );

        }
    }
}
