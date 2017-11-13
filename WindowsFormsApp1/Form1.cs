using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using static WindowsFormsApp1.ComputerConfiguration;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ComputerConfiguration initialConfig = new ComputerConfiguration();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            App2 secondApp = new App2();
            secondApp.ShowDialog();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            //ComputerConfiguration initialConfig = new ComputerConfiguration(10);
            initialConfig.Configs.Add(new Computer());

            foreach (var mobo in Motherboard.MBAvailable) cBoxMotherboard.Items.Add(mobo.productChipset);
            foreach (var cpu in CPU.CPUAvailable) cBoxCPU.Items.Add(cpu.productSocket);
            foreach (var mem in Memory.MemAvailable) cBoxMemory.Items.Add(mem.productName);
            foreach (var gpu in ComputerConfiguration.Graphics.GPUAvailable) cBoxGraphics.Items.Add(gpu.productName);
            foreach (var stor in Storage.StorageAvailable) cBoxStorage.Items.Add(stor.productName);
            foreach (var cas in Case.CaseAvailable) cBoxCase.Items.Add(cas.productName);
            foreach (var cool in Cooling.CoolingAvailable) cBoxCooling.Items.Add(cool.productName);


            MessageBox.Show(String.Format("Data has been initialized!" +
                "\r\nThere are {0} predefined configurations." +
                "\r\n\r\nYou can now choose the parts you want from the lists!", 
                initialConfig.Configs.Count));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Your PC has the following configuration: \r\n\r\n" +
                "{0} \r\n" + "{1} \r\n" + "{2} \r\n" + "{3} \r\n" + "{4} \r\n" + "{5} \r\n" + "{6} \r\n",
                cBoxMotherboard.Text, cBoxCPU.Text, cBoxMemory.Text, cBoxGraphics.Text, cBoxStorage.Text,
                cBoxCase.Text, cBoxCooling.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < initialConfig.Configs.Count; i++)
            {
                cBoxMotherboard.Items.Add(Motherboard.MBAvailable[i].productChipset);
                cBoxCPU.Items.Add(CPU.CPUAvailable[i].productSocket);
                cBoxMemory.Items.Add(Memory.MemAvailable[i].productName);
                cBoxGraphics.Items.Add(ComputerConfiguration.Graphics.GPUAvailable[i].productName);
                cBoxStorage.Items.Add(Storage.StorageAvailable[i].productName);
                cBoxCase.Items.Add(Case.CaseAvailable[i].productName);
                cBoxCooling.Items.Add(Cooling.CoolingAvailable[i].productName);
            }
        }
    }
}