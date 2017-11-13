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
            public static CPU[] CPUAvailable = new CPU[10];

            public int productID;
            public string productName;
            public string productSocket;

            public CPU()
            {
                productID = 0;
                productName = "Undefined";
                productSocket = "productChipset";

                //initializing CPUs
                for (int i = 0; i < CPUAvailable.Length; i++)
                {
                    CPUAvailable[i] = new CPU(i, String.Format("Product Name {0}", i), String.Format("Product Socket 110{0}", i));
                    //I can use the default ctor with the DB later on
                }
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