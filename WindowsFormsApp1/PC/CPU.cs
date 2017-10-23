using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    partial class ComputerConfiguration
    {
        public class CPU
        {
            public int productID;
            public string productName;
            public string productSocket;

            public CPU()
            {
                productID = 0;
                productName = "Undefined";
                productSocket = "productChipset";

            }

            public CPU(int productID, string productName, string productSocket)
            {
                this.productID = productID;
                this.productName = productName;
                this.productSocket = productSocket;
            }
        }
    }
}