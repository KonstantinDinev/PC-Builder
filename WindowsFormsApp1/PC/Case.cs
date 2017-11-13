using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    partial class ComputerConfiguration
    {
        public class Case
        {
            public static Case[] CaseAvailable = new Case[10];

            public int productID;
            public string productName;

            public Case()
            {
                productID = 0;
                productName = "Undefined";

                //initializing Cases
                for (int i = 0; i < CaseAvailable.Length; i++)
                {
                    CaseAvailable[i] = new Case(i, "NZXT Guardian 911 " + i);
                }
            }

            public Case(int productID, string productName)
            {
                this.productID = productID;
                this.productName = productName;

            }
        }
    } 
}
