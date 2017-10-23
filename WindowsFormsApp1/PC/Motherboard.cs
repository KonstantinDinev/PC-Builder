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
            public int productID;
            public string productName;
            public string productChipset;

            public Motherboard()
            {
                productID = 0;
                productName = "Undefined";
                productChipset = "productChipset";
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
