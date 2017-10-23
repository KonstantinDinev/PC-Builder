using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    partial class ComputerConfiguration
    {
        private List<Computer> configs;

        public List<Computer> Configs
        {
            get
            {
                return this.configs;
            }
            set
            {
                this.configs = value;
            }
        }

        //ctor default
        public ComputerConfiguration()
        {
            configs = new List<Computer>(10);

            //Initializing Computer Configurations
            for (int i = 0; i < configs.Capacity; i++)
            {
                configs.Add(new Computer());
            }
        }

        //ctor with params
        public ComputerConfiguration(int NumberOfConf)
        {
            //number of predefined configs. (expand the list with configs.add(new Computer());)
            this.configs = new List<Computer>(NumberOfConf);

            //Initializing Computer Configurations
            for (int i = 0; i < configs.Capacity; i++)
            {
                configs.Add(new Computer());
            }
        }

        public class Computer
        {//default ctor za predefined conf - param ctor for db
            public Motherboard[] MBAvailable;
            public CPU[] CPUAvailable;
            public Memory[] MemAvailable;
            public Graphics[] GPUAvailable;
            public Storage[] StorageAvailable;
            public Case[] CaseAvailable;
            public Cooling[] CoolingAvailable;

            public Computer()
            {
                MBAvailable = new Motherboard[10];
                CPUAvailable = new CPU[10];
                MemAvailable = new Memory[10];
                GPUAvailable = new Graphics[10];
                StorageAvailable = new Storage[10];
                CaseAvailable = new Case[10];
                CoolingAvailable = new Cooling[10];

                //initializing motherboards
                for (int i = 0; i < MBAvailable.Length; i++)
                {
                    MBAvailable[i] = new Motherboard(i /* ID */, "Product Name " + i, "Chipset " + i);
                }

                //initializing CPUs
                for (int i = 0; i < CPUAvailable.Length; i++)
                {
                    CPUAvailable[i] = new CPU(i, String.Format("Product Name {0}", i), String.Format("Product Socket 110{0}", i));
                    //I can use the default ctor with the DB later on
                }

                //initializing Memory RAM
                for (int i = 0; i < MemAvailable.Length; i++)
                {
                    MemAvailable[i] = new Memory(i, "Corsair DDR3 " + i);
                }

                //initializing Graphics GPU
                for (int i = 0; i < GPUAvailable.Length; i++)
                {
                    GPUAvailable[i] = new Graphics(i, "NVidia " + i);
                }

                //initializing Storage HDD
                for (int i = 0; i < StorageAvailable.Length; i++)
                {
                    StorageAvailable[i] = new Storage(i, "Western Digital " + i);
                }

                //initializing Cases
                for (int i = 0; i < CaseAvailable.Length; i++)
                {
                    CaseAvailable[i] = new Case(i, "NZXT Guardian 911 " + i);
                }

                //initializing Coolings
                for (int i = 0; i < CoolingAvailable.Length; i++)
                {
                    CoolingAvailable[i] = new Cooling(i, "WaterCooling " + i);
                }
            }
        }

    }
}