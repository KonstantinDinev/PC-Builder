using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    partial class ComputerConfiguration
    {
        public class Graphics
        {
            public int productID;
            public string productName;

            public Graphics()
            {
                productID = 0;
                productName = "Undefined";

            }

            public Graphics(int productID, string productName)
            {
                this.productID = productID;
                this.productName = productName;
            }
        }
    }
}