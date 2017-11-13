using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    partial class ComputerConfiguration
    {
        public class Storage
        {
            public static Storage[] StorageAvailable = new Storage[10];

            public int productID;
            public string productName;

            public Storage()
            {
                productID = 0;
                productName = "Undefined";

                //initializing Storage HDD
                for (int i = 0; i < StorageAvailable.Length; i++)
                {
                    StorageAvailable[i] = new Storage(i, "Western Digital " + i);
                }
            }

            public Storage(int productID, string productName)
            {
                this.productID = productID;
                this.productName = productName;

            }
        }
    }
}
