namespace veriant_18
{
    partial class SotrydnikForm
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
            this.SearchTxtLbl = new System.Windows.Forms.Label();
            this.RefresherOrbBtn = new System.Windows.Forms.Button();
            this.PostavshikLbl = new System.Windows.Forms.Label();
            this.SotrydnikDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SotrydnikSearchTxtBox = new System.Windows.Forms.TextBox();
            this.CAMarksLbl = new System.Windows.Forms.Label();
            this.FIOSotrydnikaTxtBx = new System.Windows.Forms.TextBox();
            this.SotrydnikNovaBtn = new System.Windows.Forms.Button();
            this.KodSotrydnikaTxtBx = new System.Windows.Forms.TextBox();
            this.NazvanieOrganLbl = new System.Windows.Forms.Label();
            this.KodPostavshikaLbl = new System.Windows.Forms.Label();
            this.SotrydnikIzmenitBtn = new System.Windows.Forms.Button();
            this.SotrydnikSohranitBtn = new System.Windows.Forms.Button();
            this.SotrydnikUdalitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SotrydnikDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchTxtLbl
            // 
            this.SearchTxtLbl.AutoSize = true;
            this.SearchTxtLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTxtLbl.Location = new System.Drawing.Point(831, 25);
            this.SearchTxtLbl.Name = "SearchTxtLbl";
            this.SearchTxtLbl.Size = new System.Drawing.Size(90, 26);
            this.SearchTxtLbl.TabIndex = 2;
            this.SearchTxtLbl.Text = "Поиск:";
            // 
            // RefresherOrbBtn
            // 
            this.RefresherOrbBtn.Location = new System.Drawing.Point(740, 12);
            this.RefresherOrbBtn.Name = "RefresherOrbBtn";
            this.RefresherOrbBtn.Size = new System.Drawing.Size(69, 58);
            this.RefresherOrbBtn.TabIndex = 3;
            this.RefresherOrbBtn.Text = "ОБНОВИТЬ";
            this.RefresherOrbBtn.UseVisualStyleBackColor = true;
            this.RefresherOrbBtn.Click += new System.EventHandler(this.RefresherOrbBtn_Click);
            // 
            // PostavshikLbl
            // 
            this.PostavshikLbl.AutoSize = true;
            this.PostavshikLbl.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostavshikLbl.Location = new System.Drawing.Point(12, 20);
            this.PostavshikLbl.Name = "PostavshikLbl";
            this.PostavshikLbl.Size = new System.Drawing.Size(189, 40);
            this.PostavshikLbl.TabIndex = 0;
            this.PostavshikLbl.Text = "Сотрудник";
            // 
            // SotrydnikDataGridView
            // 
            this.SotrydnikDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SotrydnikDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SotrydnikDataGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SotrydnikDataGridView.Location = new System.Drawing.Point(-4, 95);
            this.SotrydnikDataGridView.Name = "SotrydnikDataGridView";
            this.SotrydnikDataGridView.RowHeadersWidth = 51;
            this.SotrydnikDataGridView.Size = new System.Drawing.Size(1064, 355);
            this.SotrydnikDataGridView.TabIndex = 22;
            this.SotrydnikDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SotrydnikDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.SearchTxtLbl);
            this.panel1.Controls.Add(this.RefresherOrbBtn);
            this.panel1.Controls.Add(this.SotrydnikSearchTxtBox);
            this.panel1.Controls.Add(this.PostavshikLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 89);
            this.panel1.TabIndex = 21;
            // 
            // SotrydnikSearchTxtBox
            // 
            this.SotrydnikSearchTxtBox.Location = new System.Drawing.Point(927, 29);
            this.SotrydnikSearchTxtBox.Name = "SotrydnikSearchTxtBox";
            this.SotrydnikSearchTxtBox.Size = new System.Drawing.Size(105, 20);
            this.SotrydnikSearchTxtBox.TabIndex = 1;
            this.SotrydnikSearchTxtBox.TextChanged += new System.EventHandler(this.SotrydnikSearchTxtBox_TextChanged);
            // 
            // CAMarksLbl
            // 
            this.CAMarksLbl.AutoSize = true;
            this.CAMarksLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CAMarksLbl.Location = new System.Drawing.Point(164, 13);
            this.CAMarksLbl.Name = "CAMarksLbl";
            this.CAMarksLbl.Size = new System.Drawing.Size(62, 17);
            this.CAMarksLbl.TabIndex = 4;
            this.CAMarksLbl.Text = "Записи:";
            // 
            // FIOSotrydnikaTxtBx
            // 
            this.FIOSotrydnikaTxtBx.Location = new System.Drawing.Point(232, 167);
            this.FIOSotrydnikaTxtBx.Name = "FIOSotrydnikaTxtBx";
            this.FIOSotrydnikaTxtBx.Size = new System.Drawing.Size(143, 20);
            this.FIOSotrydnikaTxtBx.TabIndex = 3;
            // 
            // SotrydnikNovaBtn
            // 
            this.SotrydnikNovaBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.SotrydnikNovaBtn.Location = new System.Drawing.Point(24, 31);
            this.SotrydnikNovaBtn.Name = "SotrydnikNovaBtn";
            this.SotrydnikNovaBtn.Size = new System.Drawing.Size(111, 40);
            this.SotrydnikNovaBtn.TabIndex = 0;
            this.SotrydnikNovaBtn.Text = "Новая запись";
            this.SotrydnikNovaBtn.UseVisualStyleBackColor = false;
            this.SotrydnikNovaBtn.Click += new System.EventHandler(this.SotrydnikNovaBtn_Click);
            // 
            // KodSotrydnikaTxtBx
            // 
            this.KodSotrydnikaTxtBx.Location = new System.Drawing.Point(232, 100);
            this.KodSotrydnikaTxtBx.Name = "KodSotrydnikaTxtBx";
            this.KodSotrydnikaTxtBx.Size = new System.Drawing.Size(143, 20);
            this.KodSotrydnikaTxtBx.TabIndex = 2;
            // 
            // NazvanieOrganLbl
            // 
            this.NazvanieOrganLbl.AutoSize = true;
            this.NazvanieOrganLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NazvanieOrganLbl.Location = new System.Drawing.Point(20, 167);
            this.NazvanieOrganLbl.Name = "NazvanieOrganLbl";
            this.NazvanieOrganLbl.Size = new System.Drawing.Size(171, 17);
            this.NazvanieOrganLbl.TabIndex = 1;
            this.NazvanieOrganLbl.Text = "Название организации:";
            // 
            // KodPostavshikaLbl
            // 
            this.KodPostavshikaLbl.AutoSize = true;
            this.KodPostavshikaLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KodPostavshikaLbl.Location = new System.Drawing.Point(20, 100);
            this.KodPostavshikaLbl.Name = "KodPostavshikaLbl";
            this.KodPostavshikaLbl.Size = new System.Drawing.Size(127, 17);
            this.KodPostavshikaLbl.TabIndex = 0;
            this.KodPostavshikaLbl.Text = "Код поставщика:";
            // 
            // SotrydnikIzmenitBtn
            // 
            this.SotrydnikIzmenitBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.SotrydnikIzmenitBtn.Location = new System.Drawing.Point(156, 95);
            this.SotrydnikIzmenitBtn.Name = "SotrydnikIzmenitBtn";
            this.SotrydnikIzmenitBtn.Size = new System.Drawing.Size(111, 40);
            this.SotrydnikIzmenitBtn.TabIndex = 3;
            this.SotrydnikIzmenitBtn.Text = "Изменить ";
            this.SotrydnikIzmenitBtn.UseVisualStyleBackColor = false;
            this.SotrydnikIzmenitBtn.Click += new System.EventHandler(this.SotrydnikIzmenitBtn_Click);
            // 
            // SotrydnikSohranitBtn
            // 
            this.SotrydnikSohranitBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.SotrydnikSohranitBtn.Location = new System.Drawing.Point(24, 95);
            this.SotrydnikSohranitBtn.Name = "SotrydnikSohranitBtn";
            this.SotrydnikSohranitBtn.Size = new System.Drawing.Size(111, 40);
            this.SotrydnikSohranitBtn.TabIndex = 2;
            this.SotrydnikSohranitBtn.Text = "Сохранить ";
            this.SotrydnikSohranitBtn.UseVisualStyleBackColor = false;
            this.SotrydnikSohranitBtn.Click += new System.EventHandler(this.SotrydnikSohranitBtn_Click);
            // 
            // SotrydnikUdalitBtn
            // 
            this.SotrydnikUdalitBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.SotrydnikUdalitBtn.Location = new System.Drawing.Point(156, 30);
            this.SotrydnikUdalitBtn.Name = "SotrydnikUdalitBtn";
            this.SotrydnikUdalitBtn.Size = new System.Drawing.Size(111, 40);
            this.SotrydnikUdalitBtn.TabIndex = 1;
            this.SotrydnikUdalitBtn.Text = "Удалить запись";
            this.SotrydnikUdalitBtn.UseVisualStyleBackColor = false;
            this.SotrydnikUdalitBtn.Click += new System.EventHandler(this.SotrydnikUdalitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(434, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Работа с записями:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.SotrydnikIzmenitBtn);
            this.panel2.Controls.Add(this.SotrydnikSohranitBtn);
            this.panel2.Controls.Add(this.SotrydnikUdalitBtn);
            this.panel2.Controls.Add(this.SotrydnikNovaBtn);
            this.panel2.Location = new System.Drawing.Point(355, 492);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 154);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CAMarksLbl);
            this.panel3.Controls.Add(this.FIOSotrydnikaTxtBx);
            this.panel3.Controls.Add(this.KodSotrydnikaTxtBx);
            this.panel3.Controls.Add(this.NazvanieOrganLbl);
            this.panel3.Controls.Add(this.KodPostavshikaLbl);
            this.panel3.Location = new System.Drawing.Point(645, 461);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 221);
            this.panel3.TabIndex = 23;
            // 
            // SotrydnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 683);
            this.Controls.Add(this.SotrydnikDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "SotrydnikForm";
            this.Text = "SotrydnikForm";
            this.Load += new System.EventHandler(this.SotrydnikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SotrydnikDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchTxtLbl;
        private System.Windows.Forms.Button RefresherOrbBtn;
        private System.Windows.Forms.Label PostavshikLbl;
        private System.Windows.Forms.DataGridView SotrydnikDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SotrydnikSearchTxtBox;
        private System.Windows.Forms.Label CAMarksLbl;
        private System.Windows.Forms.TextBox FIOSotrydnikaTxtBx;
        private System.Windows.Forms.Button SotrydnikNovaBtn;
        private System.Windows.Forms.TextBox KodSotrydnikaTxtBx;
        private System.Windows.Forms.Label NazvanieOrganLbl;
        private System.Windows.Forms.Label KodPostavshikaLbl;
        private System.Windows.Forms.Button SotrydnikIzmenitBtn;
        private System.Windows.Forms.Button SotrydnikSohranitBtn;
        private System.Windows.Forms.Button SotrydnikUdalitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}