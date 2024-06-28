namespace veriant_18
{
    partial class PostavshikForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PostavshikIzmenitBtn = new System.Windows.Forms.Button();
            this.PostavshikSohranitBtn = new System.Windows.Forms.Button();
            this.PostavshikUdalitBtn = new System.Windows.Forms.Button();
            this.PostavshikNovaBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CAMarksLbl = new System.Windows.Forms.Label();
            this.NazvanieOrganTxtBx = new System.Windows.Forms.TextBox();
            this.KodPostavshikaTxtBx = new System.Windows.Forms.TextBox();
            this.NazvanieOrganLbl = new System.Windows.Forms.Label();
            this.KodPostavshikaLbl = new System.Windows.Forms.Label();
            this.PostavshikDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchTxtLbl = new System.Windows.Forms.Label();
            this.RefresherOrbBtn = new System.Windows.Forms.Button();
            this.PostavshikSearchTxtBox = new System.Windows.Forms.TextBox();
            this.PostavshikLbl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostavshikDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(413, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Работа с записями:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.PostavshikIzmenitBtn);
            this.panel2.Controls.Add(this.PostavshikSohranitBtn);
            this.panel2.Controls.Add(this.PostavshikUdalitBtn);
            this.panel2.Controls.Add(this.PostavshikNovaBtn);
            this.panel2.Location = new System.Drawing.Point(323, 531);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 154);
            this.panel2.TabIndex = 19;
            // 
            // PostavshikIzmenitBtn
            // 
            this.PostavshikIzmenitBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.PostavshikIzmenitBtn.Location = new System.Drawing.Point(156, 95);
            this.PostavshikIzmenitBtn.Name = "PostavshikIzmenitBtn";
            this.PostavshikIzmenitBtn.Size = new System.Drawing.Size(111, 40);
            this.PostavshikIzmenitBtn.TabIndex = 3;
            this.PostavshikIzmenitBtn.Text = "Изменить ";
            this.PostavshikIzmenitBtn.UseVisualStyleBackColor = false;
            this.PostavshikIzmenitBtn.Click += new System.EventHandler(this.PostavshikIzmenitBtn_Click);
            // 
            // PostavshikSohranitBtn
            // 
            this.PostavshikSohranitBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.PostavshikSohranitBtn.Location = new System.Drawing.Point(24, 95);
            this.PostavshikSohranitBtn.Name = "PostavshikSohranitBtn";
            this.PostavshikSohranitBtn.Size = new System.Drawing.Size(111, 40);
            this.PostavshikSohranitBtn.TabIndex = 2;
            this.PostavshikSohranitBtn.Text = "Сохранить ";
            this.PostavshikSohranitBtn.UseVisualStyleBackColor = false;
            this.PostavshikSohranitBtn.Click += new System.EventHandler(this.PostavshikSohranitBtn_Click);
            // 
            // PostavshikUdalitBtn
            // 
            this.PostavshikUdalitBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.PostavshikUdalitBtn.Location = new System.Drawing.Point(156, 30);
            this.PostavshikUdalitBtn.Name = "PostavshikUdalitBtn";
            this.PostavshikUdalitBtn.Size = new System.Drawing.Size(111, 40);
            this.PostavshikUdalitBtn.TabIndex = 1;
            this.PostavshikUdalitBtn.Text = "Удалить запись";
            this.PostavshikUdalitBtn.UseVisualStyleBackColor = false;
            this.PostavshikUdalitBtn.Click += new System.EventHandler(this.PostavshikUdalitBtn_Click);
            // 
            // PostavshikNovaBtn
            // 
            this.PostavshikNovaBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.PostavshikNovaBtn.Location = new System.Drawing.Point(24, 31);
            this.PostavshikNovaBtn.Name = "PostavshikNovaBtn";
            this.PostavshikNovaBtn.Size = new System.Drawing.Size(111, 40);
            this.PostavshikNovaBtn.TabIndex = 0;
            this.PostavshikNovaBtn.Text = "Новая запись";
            this.PostavshikNovaBtn.UseVisualStyleBackColor = false;
            this.PostavshikNovaBtn.Click += new System.EventHandler(this.PostavshikNovaBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CAMarksLbl);
            this.panel3.Controls.Add(this.NazvanieOrganTxtBx);
            this.panel3.Controls.Add(this.KodPostavshikaTxtBx);
            this.panel3.Controls.Add(this.NazvanieOrganLbl);
            this.panel3.Controls.Add(this.KodPostavshikaLbl);
            this.panel3.Location = new System.Drawing.Point(637, 500);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 221);
            this.panel3.TabIndex = 18;
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
            // NazvanieOrganTxtBx
            // 
            this.NazvanieOrganTxtBx.Location = new System.Drawing.Point(232, 167);
            this.NazvanieOrganTxtBx.Name = "NazvanieOrganTxtBx";
            this.NazvanieOrganTxtBx.Size = new System.Drawing.Size(143, 20);
            this.NazvanieOrganTxtBx.TabIndex = 3;
            // 
            // KodPostavshikaTxtBx
            // 
            this.KodPostavshikaTxtBx.Location = new System.Drawing.Point(232, 100);
            this.KodPostavshikaTxtBx.Name = "KodPostavshikaTxtBx";
            this.KodPostavshikaTxtBx.Size = new System.Drawing.Size(143, 20);
            this.KodPostavshikaTxtBx.TabIndex = 2;
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
            // PostavshikDataGridView
            // 
            this.PostavshikDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PostavshikDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PostavshikDataGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PostavshikDataGridView.Location = new System.Drawing.Point(0, 86);
            this.PostavshikDataGridView.Name = "PostavshikDataGridView";
            this.PostavshikDataGridView.RowHeadersWidth = 51;
            this.PostavshikDataGridView.Size = new System.Drawing.Size(1054, 403);
            this.PostavshikDataGridView.TabIndex = 17;
            this.PostavshikDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PostavshikDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.SearchTxtLbl);
            this.panel1.Controls.Add(this.RefresherOrbBtn);
            this.panel1.Controls.Add(this.PostavshikSearchTxtBox);
            this.panel1.Controls.Add(this.PostavshikLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 89);
            this.panel1.TabIndex = 16;
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
            // PostavshikSearchTxtBox
            // 
            this.PostavshikSearchTxtBox.Location = new System.Drawing.Point(927, 29);
            this.PostavshikSearchTxtBox.Name = "PostavshikSearchTxtBox";
            this.PostavshikSearchTxtBox.Size = new System.Drawing.Size(105, 20);
            this.PostavshikSearchTxtBox.TabIndex = 1;
            this.PostavshikSearchTxtBox.TextChanged += new System.EventHandler(this.PostavshikSearchTxtBox_TextChanged);
            // 
            // PostavshikLbl
            // 
            this.PostavshikLbl.AutoSize = true;
            this.PostavshikLbl.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostavshikLbl.Location = new System.Drawing.Point(12, 20);
            this.PostavshikLbl.Name = "PostavshikLbl";
            this.PostavshikLbl.Size = new System.Drawing.Size(210, 40);
            this.PostavshikLbl.TabIndex = 0;
            this.PostavshikLbl.Text = "Поставщик ";
            // 
            // PostavshikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 747);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PostavshikDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "PostavshikForm";
            this.Text = "Postavshik";
            this.Load += new System.EventHandler(this.PostavshikForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostavshikDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PostavshikIzmenitBtn;
        private System.Windows.Forms.Button PostavshikSohranitBtn;
        private System.Windows.Forms.Button PostavshikUdalitBtn;
        private System.Windows.Forms.Button PostavshikNovaBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label CAMarksLbl;
        private System.Windows.Forms.TextBox NazvanieOrganTxtBx;
        private System.Windows.Forms.TextBox KodPostavshikaTxtBx;
        private System.Windows.Forms.Label NazvanieOrganLbl;
        private System.Windows.Forms.Label KodPostavshikaLbl;
        private System.Windows.Forms.DataGridView PostavshikDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RefresherOrbBtn;
        private System.Windows.Forms.Label SearchTxtLbl;
        private System.Windows.Forms.TextBox PostavshikSearchTxtBox;
        private System.Windows.Forms.Label PostavshikLbl;
    }
}