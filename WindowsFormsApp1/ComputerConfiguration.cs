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
            configs = new List<Computer>();
            configs.Add(new Computer());
        }

        //ctor with params
        public ComputerConfiguration(int NumberOfConf)
        {
            //(expand the list with configs.add(new Computer());)
            this.configs = new List<Computer>(NumberOfConf);

            //Initializing Computer Configurations
            for (int i = 0; i < configs.Capacity; i++)
            {
                configs.Add(new Computer());
            }
        }

        public class Computer
        {
            public Motherboard motherboard;
            public CPU processor;
            public Memory memory;
            public Graphics graphicCard;
            public Storage storage;
            public Case casing;
            public Cooling cooler;

            public Computer()
            {
                motherboard = new Motherboard();
                processor = new CPU();
                memory = new Memory();
                graphicCard = new Graphics();
                storage = new Storage();
                casing = new Case();
                cooler = new Cooling();
            }

            //param ctor for db
        }

    }
}