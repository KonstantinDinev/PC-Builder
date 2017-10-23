using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
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
            ComputerConfiguration initialConfig = new ComputerConfiguration();
            for(int i = 0; i < initialConfig.Configs.Capacity; i++)
            {
                cBoxMotherboard.Items.Add(initialConfig.Configs[i].MBAvailable[i].productChipset);
                cBoxCPU.Items.Add(initialConfig.Configs[i].CPUAvailable[i].productSocket);
                cBoxMemory.Items.Add(initialConfig.Configs[i].MemAvailable[i].productName);
                cBoxGraphics.Items.Add(initialConfig.Configs[i].GPUAvailable[i].productName);
                cBoxStorage.Items.Add(initialConfig.Configs[i].StorageAvailable[i].productName);
                cBoxCase.Items.Add(initialConfig.Configs[i].CaseAvailable[i].productName);
                cBoxCooling.Items.Add(initialConfig.Configs[i].CoolingAvailable[i].productName);
            }

            MessageBox.Show(String.Format("Data has been initialized!" +
                "\r\nThere are {0} predefined configurations." +
                "\r\n\r\nYou can now choose the parts you want from the lists!", 
                initialConfig.Configs.Capacity));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Your PC has the following configuration: \r\n\r\n" +
                "{0} \r\n" + "{1} \r\n" + "{2} \r\n" + "{3} \r\n" + "{4} \r\n" + "{5} \r\n" + "{6} \r\n",
                cBoxMotherboard.Text, cBoxCPU.Text, cBoxMemory.Text, cBoxGraphics.Text, cBoxStorage.Text,
                cBoxCase.Text, cBoxCooling.Text));
        }
    }
}