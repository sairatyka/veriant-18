namespace veriant_18
{
    partial class DogovorForm
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
            this.DogovorDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DogovorSearchTxtBox = new System.Windows.Forms.TextBox();
            this.CAMarksLbl = new System.Windows.Forms.Label();
            this.NomerKPTxtBx = new System.Windows.Forms.TextBox();
            this.DogovorNovaBtn = new System.Windows.Forms.Button();
            this.NomerDogovoraTxtBx = new System.Windows.Forms.TextBox();
            this.NazvanieOrganLbl = new System.Windows.Forms.Label();
            this.KodPostavshikaLbl = new System.Windows.Forms.Label();
            this.DogovorIzmenitBtn = new System.Windows.Forms.Button();
            this.DogovorSohranitBtn = new System.Windows.Forms.Button();
            this.DogovorUdalitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.KolichestvoPostTxtBx = new System.Windows.Forms.TextBox();
            this.StoimostPostTxtBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DataZaclychTxtBx = new System.Windows.Forms.TextBox();
            this.KodSotrydnikaTxtBx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.KodTovaraTxtBx = new System.Windows.Forms.TextBox();
            this.KodPostTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DogovorDataGridView)).BeginInit();
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
            this.PostavshikLbl.Size = new System.Drawing.Size(147, 40);
            this.PostavshikLbl.TabIndex = 0;
            this.PostavshikLbl.Text = "Договор";
            // 
            // DogovorDataGridView
            // 
            this.DogovorDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DogovorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DogovorDataGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DogovorDataGridView.Location = new System.Drawing.Point(0, 91);
            this.DogovorDataGridView.Name = "DogovorDataGridView";
            this.DogovorDataGridView.RowHeadersWidth = 51;
            this.DogovorDataGridView.Size = new System.Drawing.Size(1065, 362);
            this.DogovorDataGridView.TabIndex = 22;
            this.DogovorDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DogovorDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.SearchTxtLbl);
            this.panel1.Controls.Add(this.RefresherOrbBtn);
            this.panel1.Controls.Add(this.DogovorSearchTxtBox);
            this.panel1.Controls.Add(this.PostavshikLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 89);
            this.panel1.TabIndex = 21;
            // 
            // DogovorSearchTxtBox
            // 
            this.DogovorSearchTxtBox.Location = new System.Drawing.Point(927, 29);
            this.DogovorSearchTxtBox.Name = "DogovorSearchTxtBox";
            this.DogovorSearchTxtBox.Size = new System.Drawing.Size(105, 20);
            this.DogovorSearchTxtBox.TabIndex = 1;
            this.DogovorSearchTxtBox.TextChanged += new System.EventHandler(this.DogovorSearchTxtBox_TextChanged);
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
            // NomerKPTxtBx
            // 
            this.NomerKPTxtBx.Location = new System.Drawing.Point(232, 65);
            this.NomerKPTxtBx.Name = "NomerKPTxtBx";
            this.NomerKPTxtBx.Size = new System.Drawing.Size(143, 20);
            this.NomerKPTxtBx.TabIndex = 3;
            // 
            // DogovorNovaBtn
            // 
            this.DogovorNovaBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.DogovorNovaBtn.Location = new System.Drawing.Point(24, 31);
            this.DogovorNovaBtn.Name = "DogovorNovaBtn";
            this.DogovorNovaBtn.Size = new System.Drawing.Size(111, 40);
            this.DogovorNovaBtn.TabIndex = 0;
            this.DogovorNovaBtn.Text = "Новая запись";
            this.DogovorNovaBtn.UseVisualStyleBackColor = false;
            this.DogovorNovaBtn.Click += new System.EventHandler(this.DogovorNovaBtn_Click);
            // 
            // NomerDogovoraTxtBx
            // 
            this.NomerDogovoraTxtBx.Location = new System.Drawing.Point(232, 33);
            this.NomerDogovoraTxtBx.Name = "NomerDogovoraTxtBx";
            this.NomerDogovoraTxtBx.Size = new System.Drawing.Size(143, 20);
            this.NomerDogovoraTxtBx.TabIndex = 2;
            // 
            // NazvanieOrganLbl
            // 
            this.NazvanieOrganLbl.AutoSize = true;
            this.NazvanieOrganLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NazvanieOrganLbl.Location = new System.Drawing.Point(20, 68);
            this.NazvanieOrganLbl.Name = "NazvanieOrganLbl";
            this.NazvanieOrganLbl.Size = new System.Drawing.Size(86, 17);
            this.NazvanieOrganLbl.TabIndex = 1;
            this.NazvanieOrganLbl.Text = "Номер КП:";
            // 
            // KodPostavshikaLbl
            // 
            this.KodPostavshikaLbl.AutoSize = true;
            this.KodPostavshikaLbl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KodPostavshikaLbl.Location = new System.Drawing.Point(20, 38);
            this.KodPostavshikaLbl.Name = "KodPostavshikaLbl";
            this.KodPostavshikaLbl.Size = new System.Drawing.Size(125, 17);
            this.KodPostavshikaLbl.TabIndex = 0;
            this.KodPostavshikaLbl.Text = "Номер договора:";
            // 
            // DogovorIzmenitBtn
            // 
            this.DogovorIzmenitBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.DogovorIzmenitBtn.Location = new System.Drawing.Point(156, 95);
            this.DogovorIzmenitBtn.Name = "DogovorIzmenitBtn";
            this.DogovorIzmenitBtn.Size = new System.Drawing.Size(111, 40);
            this.DogovorIzmenitBtn.TabIndex = 3;
            this.DogovorIzmenitBtn.Text = "Изменить ";
            this.DogovorIzmenitBtn.UseVisualStyleBackColor = false;
            this.DogovorIzmenitBtn.Click += new System.EventHandler(this.IzmenitBtn_Click);
            // 
            // DogovorSohranitBtn
            // 
            this.DogovorSohranitBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.DogovorSohranitBtn.Location = new System.Drawing.Point(24, 95);
            this.DogovorSohranitBtn.Name = "DogovorSohranitBtn";
            this.DogovorSohranitBtn.Size = new System.Drawing.Size(111, 40);
            this.DogovorSohranitBtn.TabIndex = 2;
            this.DogovorSohranitBtn.Text = "Сохранить ";
            this.DogovorSohranitBtn.UseVisualStyleBackColor = false;
            this.DogovorSohranitBtn.Click += new System.EventHandler(this.SohranitBtn_Click);
            // 
            // DogovorUdalitBtn
            // 
            this.DogovorUdalitBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.DogovorUdalitBtn.Location = new System.Drawing.Point(156, 30);
            this.DogovorUdalitBtn.Name = "DogovorUdalitBtn";
            this.DogovorUdalitBtn.Size = new System.Drawing.Size(111, 40);
            this.DogovorUdalitBtn.TabIndex = 1;
            this.DogovorUdalitBtn.Text = "Удалить запись";
            this.DogovorUdalitBtn.UseVisualStyleBackColor = false;
            this.DogovorUdalitBtn.Click += new System.EventHandler(this.UdalitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(413, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Работа с записями:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.DogovorIzmenitBtn);
            this.panel2.Controls.Add(this.DogovorSohranitBtn);
            this.panel2.Controls.Add(this.DogovorUdalitBtn);
            this.panel2.Controls.Add(this.DogovorNovaBtn);
            this.panel2.Location = new System.Drawing.Point(323, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 149);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.KolichestvoPostTxtBx);
            this.panel3.Controls.Add(this.StoimostPostTxtBx);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.DataZaclychTxtBx);
            this.panel3.Controls.Add(this.KodSotrydnikaTxtBx);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.KodTovaraTxtBx);
            this.panel3.Controls.Add(this.KodPostTxtBx);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.CAMarksLbl);
            this.panel3.Controls.Add(this.NomerKPTxtBx);
            this.panel3.Controls.Add(this.NomerDogovoraTxtBx);
            this.panel3.Controls.Add(this.NazvanieOrganLbl);
            this.panel3.Controls.Add(this.KodPostavshikaLbl);
            this.panel3.Location = new System.Drawing.Point(648, 464);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(406, 282);
            this.panel3.TabIndex = 23;
            // 
            // KolichestvoPostTxtBx
            // 
            this.KolichestvoPostTxtBx.Location = new System.Drawing.Point(232, 237);
            this.KolichestvoPostTxtBx.Name = "KolichestvoPostTxtBx";
            this.KolichestvoPostTxtBx.Size = new System.Drawing.Size(143, 20);
            this.KolichestvoPostTxtBx.TabIndex = 16;
            // 
            // StoimostPostTxtBx
            // 
            this.StoimostPostTxtBx.Location = new System.Drawing.Point(232, 211);
            this.StoimostPostTxtBx.Name = "StoimostPostTxtBx";
            this.StoimostPostTxtBx.Size = new System.Drawing.Size(143, 20);
            this.StoimostPostTxtBx.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Количество поставки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Стоимость поставки:";
            // 
            // DataZaclychTxtBx
            // 
            this.DataZaclychTxtBx.Location = new System.Drawing.Point(232, 183);
            this.DataZaclychTxtBx.Name = "DataZaclychTxtBx";
            this.DataZaclychTxtBx.Size = new System.Drawing.Size(143, 20);
            this.DataZaclychTxtBx.TabIndex = 12;
            // 
            // KodSotrydnikaTxtBx
            // 
            this.KodSotrydnikaTxtBx.Location = new System.Drawing.Point(232, 151);
            this.KodSotrydnikaTxtBx.Name = "KodSotrydnikaTxtBx";
            this.KodSotrydnikaTxtBx.Size = new System.Drawing.Size(143, 20);
            this.KodSotrydnikaTxtBx.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дата заключения договора:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(20, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Код сотрудника:";
            // 
            // KodTovaraTxtBx
            // 
            this.KodTovaraTxtBx.Location = new System.Drawing.Point(232, 119);
            this.KodTovaraTxtBx.Name = "KodTovaraTxtBx";
            this.KodTovaraTxtBx.Size = new System.Drawing.Size(143, 20);
            this.KodTovaraTxtBx.TabIndex = 8;
            // 
            // KodPostTxtBx
            // 
            this.KodPostTxtBx.Location = new System.Drawing.Point(232, 91);
            this.KodPostTxtBx.Name = "KodPostTxtBx";
            this.KodPostTxtBx.Size = new System.Drawing.Size(143, 20);
            this.KodPostTxtBx.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Код товара:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Код поставщика:";
            // 
            // DogovorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 739);
            this.Controls.Add(this.DogovorDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "DogovorForm";
            this.Text = "DogovorForm";
            this.Load += new System.EventHandler(this.DogovorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DogovorDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView DogovorDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox DogovorSearchTxtBox;
        private System.Windows.Forms.Label CAMarksLbl;
        private System.Windows.Forms.TextBox NomerKPTxtBx;
        private System.Windows.Forms.Button DogovorNovaBtn;
        private System.Windows.Forms.TextBox NomerDogovoraTxtBx;
        private System.Windows.Forms.Label NazvanieOrganLbl;
        private System.Windows.Forms.Label KodPostavshikaLbl;
        private System.Windows.Forms.Button DogovorIzmenitBtn;
        private System.Windows.Forms.Button DogovorSohranitBtn;
        private System.Windows.Forms.Button DogovorUdalitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox KodTovaraTxtBx;
        private System.Windows.Forms.TextBox KodPostTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox KolichestvoPostTxtBx;
        private System.Windows.Forms.TextBox StoimostPostTxtBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DataZaclychTxtBx;
        private System.Windows.Forms.TextBox KodSotrydnikaTxtBx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}