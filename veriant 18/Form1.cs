using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriant_18
{
    public partial class Form1 : Form
    {
        database__connect dataBase = new database__connect();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PostavshikForm postavshikForm = new PostavshikForm();
            postavshikForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TovarForm tovarForm = new TovarForm();
            tovarForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SotrydnikForm sotrydnikForm = new SotrydnikForm();  
            sotrydnikForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DogovorForm dogovorForm = new DogovorForm();
            dogovorForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KomPredlozhFrom komPredlozhFrom = new KomPredlozhFrom();
            komPredlozhFrom.ShowDialog();
        }
    }
}
