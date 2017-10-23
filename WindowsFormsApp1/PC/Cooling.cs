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
            public int productID;
            public string productName;

            public Cooling()
            {
                productID = 0;
                productName = "Undefined";

            }

            public Cooling(int productID, string productName)
            {
                this.productID = productID;
                this.productName = productName;
            }
        }
    }
}
