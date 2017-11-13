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
            public static Graphics[] GPUAvailable = new Graphics[10];
            public int productID;
            public string productName;

            public Graphics()
            {
                productID = 0;
                productName = "Undefined";

                //initializing Graphics GPU
                for (int i = 0; i < GPUAvailable.Length; i++)
                {
                    GPUAvailable[i] = new Graphics(i, "NVidia " + i);
                }
            }

            public Graphics(int productID, string productName)
            {
                this.productID = productID;
                this.productName = productName;

            }
        }
    }
}