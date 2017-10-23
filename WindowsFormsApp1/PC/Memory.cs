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
            public int productID;
            public string productName;

            public Memory()
            {
                productID = 0;
                productName = "Undefined";

            }

            public Memory(int productID, string productName)
            {
                this.productID = productID;
                this.productName = productName;
            }
        }
    }
}
