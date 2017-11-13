using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    partial class ComputerConfiguration
    {
        public class Cooling
        {
            public static Cooling[] CoolingAvailable = new Cooling[10];

            public int productID;
            public string productName;

            public Cooling()
            {
                productID = 0;
                productName = "Undefined";

                //initializing Coolings
                for (int i = 0; i < CoolingAvailable.Length; i++)
                {
                    CoolingAvailable[i] = new Cooling(i, "WaterCooling " + i);
                }
            }

            public Cooling(int productID, string productName)
            {
                this.productID = productID;
                this.productName = productName;

            }
        }
    }
}
