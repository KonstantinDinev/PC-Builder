using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    partial class ComputerConfiguration
    {
        public class Motherboard
        {
            static public Motherboard[] MBAvailable = new Motherboard[10];

            public int productID;
            public string productName;
            public string productChipset;

            public Motherboard()
            {
                productID = 0;
                productName = "Undefined";
                productChipset = "productChipset";

                //initializing motherboards
                for (int i = 0; i < MBAvailable.Length; i++)
                {
                    MBAvailable[i] = new Motherboard(i /* ID */, "Product Name " + i, "Chipset " + i);
                }
            }

            public Motherboard(int productID, string productName, string productChipset)
            {
                this.productID = productID;
                this.productName = productName;
                this.productChipset = productChipset;
            }
        }

    }

}
