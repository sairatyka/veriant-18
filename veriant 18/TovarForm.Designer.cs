namespace veriant_18
{
    partial class TovarForm
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
            this.TovarDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TovarSearchTxtBox = new System.Windows.Forms.TextBox();
            this.CAMarksLbl = new System.Windows.Forms.Label();
            this.NazvanieTovaraTxtBx = new System.Windows.Forms.TextBox();
            this.TovarNovaBtn = new System.Windows.Forms.Button();
            this.KodTovaraTxtBx = new System.Windows.Forms.TextBox();
            this.NazvanieTovaraLbl = new System.Windows.Forms.Label();
            this.KodTovaraLbl = new System.Windows.Forms.Label();
            this.TovarIzmenitBtn = new System.Windows.Forms.Button();
            this.TovarSohranitBtn = new System.Windows.Forms.Button();
            this.TovarUdalitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TovarDataGridView)).BeginInit();
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
            this.PostavshikLbl.Size = new System.Drawing.Size(111, 40);
            this.PostavshikLbl.TabIndex = 0;
            this.PostavshikLbl.Text = "Товар";
            // 
            // TovarDataGridView
            // 
            this.TovarDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TovarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TovarDataGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TovarDataGridView.Location = new System.Drawing.Point(0, 95);
            this.TovarDataGridView.Name = "TovarDataGridView";
            this.TovarDataGridView.RowHeadersWidth = 51;
            this.TovarDataGridView.Size = new System.Drawing.Size(1054, 383);
            this.TovarDataGridView.TabIndex = 22;
            this.TovarDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TovarDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.SearchTxtLbl);
            this.panel1.Controls.Add(this.RefresherOrbBtn);
            this.panel1.Controls.Add(this.TovarSearchTxtBox);
            this.panel1.Controls.Add(this.PostavshikLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 89);
            this.panel1.TabIndex = 21;
            // 
            // TovarSearchTxtBox
            // 
            this.TovarSearchTxtBox.Location = new System.Drawing.Point(927, 29);
            this.TovarSearchTxtBox.Name = "TovarSearchTxtBox";
            this.TovarSearchTxtBox.Size = new System.Drawing.Size(105, 20);
            this.TovarSearchTxtBox.TabIndex = 1;
            this.TovarSearchTxtBox.TextChanged += new System.EventHandler(this.TovarSearchTxtBox_TextChanged);
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
            // NazvanieTovaraTxtBx
            // 
            this.NazvanieTovaraTxtBx.Location = new System.Drawing.Point(232, 167);
            this.NazvanieTovaraTxtBx.Name = "NazvanieTovaraTxtBx";
            this.NazvanieTovaraTxtBx.Size = new System.Drawing.Size(143, 20);
            this.NazvanieTovaraTxtBx.TabIndex = 3;
            // 
            // TovarNovaBtn
            // 
            this.TovarNovaBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.TovarNovaBtn.Location = new System.Drawing.Point(24, 31);
            this.TovarNovaBtn.Name = "TovarNovaBtn";
            this.TovarNovaBtn.Size = new System.Drawing.Size(111, 40);
            this.TovarNovaBtn.TabIndex = 0;
            this.TovarNovaBtn.Text = "Новая запись";
            this.TovarNovaBtn.UseVisualStyleBackColor = false;
            this.TovarNovaBtn.Click += new System.EventHandler(this.TovarNovaBtn_Click);
            // 
            // KodTovaraTxtBx
            // 
            this.KodTovaraTxtBx.Location = new System.Drawing.Point(232, 100);
            this.KodTovaraTxtBx.Name = "KodTovaraTxtBx";
            this.KodTovaraTxtBx.Size = new System.Drawing.Size(143, 20);
            this.KodTovaraTxtBx.TabIndex = 2;
            // 
            // NazvanieTovaraLbl
            // 
            this.NazvanieTovaraLbl.AutoSize = true;
            this.NazvanieTovaraLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NazvanieTovaraLbl.Location = new System.Drawing.Point(20, 167);
            this.NazvanieTovaraLbl.Name = "NazvanieTovaraLbl";
            this.NazvanieTovaraLbl.Size = new System.Drawing.Size(129, 17);
            this.NazvanieTovaraLbl.TabIndex = 1;
            this.NazvanieTovaraLbl.Text = "Название товара:";
            // 
            // KodTovaraLbl
            // 
            this.KodTovaraLbl.AutoSize = true;
            this.KodTovaraLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KodTovaraLbl.Location = new System.Drawing.Point(20, 100);
            this.KodTovaraLbl.Name = "KodTovaraLbl";
            this.KodTovaraLbl.Size = new System.Drawing.Size(89, 17);
            this.KodTovaraLbl.TabIndex = 0;
            this.KodTovaraLbl.Text = "Код товара:";
            // 
            // TovarIzmenitBtn
            // 
            this.TovarIzmenitBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.TovarIzmenitBtn.Location = new System.Drawing.Point(156, 95);
            this.TovarIzmenitBtn.Name = "TovarIzmenitBtn";
            this.TovarIzmenitBtn.Size = new System.Drawing.Size(111, 40);
            this.TovarIzmenitBtn.TabIndex = 3;
            this.TovarIzmenitBtn.Text = "Изменить ";
            this.TovarIzmenitBtn.UseVisualStyleBackColor = false;
            this.TovarIzmenitBtn.Click += new System.EventHandler(this.TovarIzmenitBtn_Click);
            // 
            // TovarSohranitBtn
            // 
            this.TovarSohranitBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.TovarSohranitBtn.Location = new System.Drawing.Point(24, 95);
            this.TovarSohranitBtn.Name = "TovarSohranitBtn";
            this.TovarSohranitBtn.Size = new System.Drawing.Size(111, 40);
            this.TovarSohranitBtn.TabIndex = 2;
            this.TovarSohranitBtn.Text = "Сохранить ";
            this.TovarSohranitBtn.UseVisualStyleBackColor = false;
            this.TovarSohranitBtn.Click += new System.EventHandler(this.TovarSohranitBtn_Click);
            // 
            // TovarUdalitBtn
            // 
            this.TovarUdalitBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.TovarUdalitBtn.Location = new System.Drawing.Point(156, 30);
            this.TovarUdalitBtn.Name = "TovarUdalitBtn";
            this.TovarUdalitBtn.Size = new System.Drawing.Size(111, 40);
            this.TovarUdalitBtn.TabIndex = 1;
            this.TovarUdalitBtn.Text = "Удалить запись";
            this.TovarUdalitBtn.UseVisualStyleBackColor = false;
            this.TovarUdalitBtn.Click += new System.EventHandler(this.TovarUdalitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(413, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Работа с записями:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.TovarIzmenitBtn);
            this.panel2.Controls.Add(this.TovarSohranitBtn);
            this.panel2.Controls.Add(this.TovarUdalitBtn);
            this.panel2.Controls.Add(this.TovarNovaBtn);
            this.panel2.Location = new System.Drawing.Point(328, 510);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 154);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CAMarksLbl);
            this.panel3.Controls.Add(this.NazvanieTovaraTxtBx);
            this.panel3.Controls.Add(this.KodTovaraTxtBx);
            this.panel3.Controls.Add(this.NazvanieTovaraLbl);
            this.panel3.Controls.Add(this.KodTovaraLbl);
            this.panel3.Location = new System.Drawing.Point(637, 496);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 221);
            this.panel3.TabIndex = 23;
            // 
            // TovarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 729);
            this.Controls.Add(this.TovarDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "TovarForm";
            this.Text = "TovarForm";
            this.Load += new System.EventHandler(this.TovarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TovarDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView TovarDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TovarSearchTxtBox;
        private System.Windows.Forms.Label CAMarksLbl;
        private System.Windows.Forms.TextBox NazvanieTovaraTxtBx;
        private System.Windows.Forms.Button TovarNovaBtn;
        private System.Windows.Forms.TextBox KodTovaraTxtBx;
        private System.Windows.Forms.Label NazvanieTovaraLbl;
        private System.Windows.Forms.Label KodTovaraLbl;
        private System.Windows.Forms.Button TovarIzmenitBtn;
        private System.Windows.Forms.Button TovarSohranitBtn;
        private System.Windows.Forms.Button TovarUdalitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}