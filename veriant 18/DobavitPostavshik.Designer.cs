namespace veriant_18
{
    partial class DobavitPostavshik
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DobavitBTN = new System.Windows.Forms.Button();
            this.NazvanieOrganTXTBX = new System.Windows.Forms.TextBox();
            this.KodPostavshikaTXTBX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(206, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавьте запись:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.DobavitBTN);
            this.panel2.Controls.Add(this.NazvanieOrganTXTBX);
            this.panel2.Controls.Add(this.KodPostavshikaTXTBX);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 320);
            this.panel2.TabIndex = 1;
            // 
            // DobavitBTN
            // 
            this.DobavitBTN.Location = new System.Drawing.Point(485, 254);
            this.DobavitBTN.Name = "DobavitBTN";
            this.DobavitBTN.Size = new System.Drawing.Size(118, 48);
            this.DobavitBTN.TabIndex = 5;
            this.DobavitBTN.Text = "Добавить";
            this.DobavitBTN.UseVisualStyleBackColor = true;
            this.DobavitBTN.Click += new System.EventHandler(this.DobavitBTN_Click);
            // 
            // NazvanieOrganTXTBX
            // 
            this.NazvanieOrganTXTBX.Location = new System.Drawing.Point(347, 140);
            this.NazvanieOrganTXTBX.Name = "NazvanieOrganTXTBX";
            this.NazvanieOrganTXTBX.Size = new System.Drawing.Size(256, 20);
            this.NazvanieOrganTXTBX.TabIndex = 4;
            // 
            // KodPostavshikaTXTBX
            // 
            this.KodPostavshikaTXTBX.Location = new System.Drawing.Point(347, 69);
            this.KodPostavshikaTXTBX.Name = "KodPostavshikaTXTBX";
            this.KodPostavshikaTXTBX.Size = new System.Drawing.Size(256, 20);
            this.KodPostavshikaTXTBX.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Код поставщика:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название организации:";
            // 
            // DobavitPostavshik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DobavitPostavshik";
            this.Text = "DobavitPostavshik";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NazvanieOrganTXTBX;
        private System.Windows.Forms.TextBox KodPostavshikaTXTBX;
        private System.Windows.Forms.Button DobavitBTN;
    }
}