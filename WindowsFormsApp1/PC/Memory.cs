using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    partial class ComputerConfiguration
    {
        public class Memory
        {
            public static Memory[] MemAvailable = new Memory[10];

            public int productID;
            public string productName;

            public Memory()
            {
                productID = 0;
                productName = "Undefined";

                //initializing Memory RAM
                for (int i = 0; i < MemAvailable.Length; i++)
                {
                    MemAvailable[i] = new Memory(i, "Corsair DDR3 " + i);
                }
            }

            public Memory(int productID, string productName)
            {
                this.productID = productID;
                this.productName = productName;

            }
        }
    }
}
