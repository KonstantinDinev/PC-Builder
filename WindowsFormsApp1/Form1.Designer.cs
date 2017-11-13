namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetData = new System.Windows.Forms.Button();
            this.lblMotherboard = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.cBoxMotherboard = new System.Windows.Forms.ComboBox();
            this.cBoxCPU = new System.Windows.Forms.ComboBox();
            this.lblMemory = new System.Windows.Forms.Label();
            this.lblGraphics = new System.Windows.Forms.Label();
            this.lblStorage = new System.Windows.Forms.Label();
            this.lblCase = new System.Windows.Forms.Label();
            this.lblCooling = new System.Windows.Forms.Label();
            this.cBoxMemory = new System.Windows.Forms.ComboBox();
            this.cBoxGraphics = new System.Windows.Forms.ComboBox();
            this.cBoxStorage = new System.Windows.Forms.ComboBox();
            this.cBoxCase = new System.Windows.Forms.ComboBox();
            this.cBoxCooling = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(15, 230);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(72, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "App 2";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Build Your Dreamed PC Now!";
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(16, 33);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(71, 191);
            this.btnGetData.TabIndex = 2;
            this.btnGetData.Text = "Populate Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // lblMotherboard
            // 
            this.lblMotherboard.AutoSize = true;
            this.lblMotherboard.Location = new System.Drawing.Point(93, 37);
            this.lblMotherboard.Name = "lblMotherboard";
            this.lblMotherboard.Size = new System.Drawing.Size(67, 13);
            this.lblMotherboard.TabIndex = 3;
            this.lblMotherboard.Text = "Motherboard";
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(93, 82);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(29, 13);
            this.lblCPU.TabIndex = 4;
            this.lblCPU.Text = "CPU";
            // 
            // cBoxMotherboard
            // 
            this.cBoxMotherboard.FormattingEnabled = true;
            this.cBoxMotherboard.Location = new System.Drawing.Point(96, 53);
            this.cBoxMotherboard.Name = "cBoxMotherboard";
            this.cBoxMotherboard.Size = new System.Drawing.Size(121, 21);
            this.cBoxMotherboard.TabIndex = 5;
            // 
            // cBoxCPU
            // 
            this.cBoxCPU.FormattingEnabled = true;
            this.cBoxCPU.Location = new System.Drawing.Point(96, 98);
            this.cBoxCPU.Name = "cBoxCPU";
            this.cBoxCPU.Size = new System.Drawing.Size(121, 21);
            this.cBoxCPU.TabIndex = 6;
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Location = new System.Drawing.Point(93, 125);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(44, 13);
            this.lblMemory.TabIndex = 7;
            this.lblMemory.Text = "Memory";
            // 
            // lblGraphics
            // 
            this.lblGraphics.AutoSize = true;
            this.lblGraphics.Location = new System.Drawing.Point(93, 169);
            this.lblGraphics.Name = "lblGraphics";
            this.lblGraphics.Size = new System.Drawing.Size(49, 13);
            this.lblGraphics.TabIndex = 8;
            this.lblGraphics.Text = "Graphics";
            // 
            // lblStorage
            // 
            this.lblStorage.AutoSize = true;
            this.lblStorage.Location = new System.Drawing.Point(93, 211);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(44, 13);
            this.lblStorage.TabIndex = 9;
            this.lblStorage.Text = "Storage";
            // 
            // lblCase
            // 
            this.lblCase.AutoSize = true;
            this.lblCase.Location = new System.Drawing.Point(267, 37);
            this.lblCase.Name = "lblCase";
            this.lblCase.Size = new System.Drawing.Size(31, 13);
            this.lblCase.TabIndex = 10;
            this.lblCase.Text = "Case";
            // 
            // lblCooling
            // 
            this.lblCooling.AutoSize = true;
            this.lblCooling.Location = new System.Drawing.Point(267, 82);
            this.lblCooling.Name = "lblCooling";
            this.lblCooling.Size = new System.Drawing.Size(79, 13);
            this.lblCooling.TabIndex = 11;
            this.lblCooling.Text = "Cooling System";
            // 
            // cBoxMemory
            // 
            this.cBoxMemory.FormattingEnabled = true;
            this.cBoxMemory.Location = new System.Drawing.Point(96, 141);
            this.cBoxMemory.Name = "cBoxMemory";
            this.cBoxMemory.Size = new System.Drawing.Size(121, 21);
            this.cBoxMemory.TabIndex = 12;
            // 
            // cBoxGraphics
            // 
            this.cBoxGraphics.FormattingEnabled = true;
            this.cBoxGraphics.Location = new System.Drawing.Point(96, 185);
            this.cBoxGraphics.Name = "cBoxGraphics";
            this.cBoxGraphics.Size = new System.Drawing.Size(121, 21);
            this.cBoxGraphics.TabIndex = 13;
            // 
            // cBoxStorage
            // 
            this.cBoxStorage.FormattingEnabled = true;
            this.cBoxStorage.Location = new System.Drawing.Point(96, 230);
            this.cBoxStorage.Name = "cBoxStorage";
            this.cBoxStorage.Size = new System.Drawing.Size(121, 21);
            this.cBoxStorage.TabIndex = 14;
            // 
            // cBoxCase
            // 
            this.cBoxCase.FormattingEnabled = true;
            this.cBoxCase.Location = new System.Drawing.Point(270, 53);
            this.cBoxCase.Name = "cBoxCase";
            this.cBoxCase.Size = new System.Drawing.Size(121, 21);
            this.cBoxCase.TabIndex = 15;
            // 
            // cBoxCooling
            // 
            this.cBoxCooling.FormattingEnabled = true;
            this.cBoxCooling.Location = new System.Drawing.Point(270, 98);
            this.cBoxCooling.Name = "cBoxCooling";
            this.cBoxCooling.Size = new System.Drawing.Size(121, 21);
            this.cBoxCooling.TabIndex = 16;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(267, 213);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 13);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Total: 0$";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(270, 228);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 278);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.cBoxCooling);
            this.Controls.Add(this.cBoxCase);
            this.Controls.Add(this.cBoxStorage);
            this.Controls.Add(this.cBoxGraphics);
            this.Controls.Add(this.cBoxMemory);
            this.Controls.Add(this.lblCooling);
            this.Controls.Add(this.lblCase);
            this.Controls.Add(this.lblStorage);
            this.Controls.Add(this.lblGraphics);
            this.Controls.Add(this.lblMemory);
            this.Controls.Add(this.cBoxCPU);
            this.Controls.Add(this.cBoxMotherboard);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblMotherboard);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Estimate Your PC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Label lblMotherboard;
        private System.Windows.Forms.Label lblCPU;
        public System.Windows.Forms.ComboBox cBoxMotherboard;
        public System.Windows.Forms.ComboBox cBoxCPU;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Label lblGraphics;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.Label lblCase;
        private System.Windows.Forms.Label lblCooling;
        private System.Windows.Forms.ComboBox cBoxMemory;
        private System.Windows.Forms.ComboBox cBoxGraphics;
        private System.Windows.Forms.ComboBox cBoxStorage;
        private System.Windows.Forms.ComboBox cBoxCase;
        private System.Windows.Forms.ComboBox cBoxCooling;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnSubmit;
    }
}

