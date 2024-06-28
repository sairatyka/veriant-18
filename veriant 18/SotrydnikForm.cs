using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriant_18
{
    public partial class SotrydnikForm : Form
    {

        database__connect dbCon = new database__connect();

        public SotrydnikForm()
        {
            InitializeComponent();
            SotrydnikDataGridView.AllowUserToAddRows = false;
        }

        private int selectedRow;

        public void SozdatStolb()
        {
            SotrydnikDataGridView.Columns.Add("Kod sotrydnika", "Код сотрудника");
            SotrydnikDataGridView.Columns.Add("FIO sotrydnika", "ФИО сотрудника");
            SotrydnikDataGridView.Columns.Add("Sostoyanie", String.Empty);

            SotrydnikDataGridView.Columns["Sostoyanie"].Visible = false;

            SotrydnikDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void ReadSingleRow(DataGridView dataGridView, IDataRecord record)
        {
            dataGridView.Rows.Add(record.GetInt32(0), record.GetString(1), Sostoyanie.exsisted);
        }

        public void ObnovitTable(DataGridView dataGridView)
        {


            SotrydnikDataGridView.Rows.Clear();

            dbCon.openConnection();

            string Zapros = "Select * From Сотрудник";

            SqlCommand command = new SqlCommand(Zapros, dbCon.getConnection());

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView, reader);
            }

            reader.Close();
        }

        private void SotrydnikForm_Load(object sender, EventArgs e)
        {
            if (SotrydnikDataGridView.Rows.Count == 0)
            {
                SozdatStolb();
            }

            ObnovitTable(SotrydnikDataGridView);
        }

        private void SotrydnikSohranitBtn_Click(object sender, EventArgs e)
        {
            Sohranit();
        }

        private void Sohranit()
        {
            dbCon.openConnection();

            for (int index = 0; index < SotrydnikDataGridView.Rows.Count; index++)
            {
                Sostoyanie sostoyanie = (Sostoyanie) SotrydnikDataGridView.Rows[index].Cells[2].Value;

                if (sostoyanie == Sostoyanie.deleted)
                {
                    int KodSotrydnika = Convert.ToInt32(SotrydnikDataGridView.Rows[index].Cells[0].Value);

                    string UdalitZapros = $"Delete from Сотрудник where КодСотрудника = {KodSotrydnika}";

                    SqlCommand command = new SqlCommand(UdalitZapros, dbCon.getConnection());

                    command.ExecuteNonQuery();
                }

                if (sostoyanie == Sostoyanie.modified)
                {
                    int KodSotrydnika = Convert.ToInt32(KodSotrydnikaTxtBx.Text);
                    string FIOSotrydnika = FIOSotrydnikaTxtBx.Text;

                    string IzmenitZapros = "Update Сотрудник Set ФИОСотрудника = @FIOSotrydnika where КодСотрудника = @kodSotrydnika";

                    SqlCommand command = new SqlCommand(IzmenitZapros, dbCon.getConnection());

                    command.Parameters.AddWithValue("@kodSotrydnika", KodSotrydnika);
                    command.Parameters.AddWithValue("@FIOSotrydnika", FIOSotrydnika);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно обновлена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Произошла ошибка: {ex.Message}", "ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

            dbCon.closeConnection();
        }

        private void SotrydnikUdalitBtn_Click(object sender, EventArgs e)
        {
            Udalit();
        }

        private void Udalit()
        {
            int index = SotrydnikDataGridView.CurrentCell.RowIndex;

            SotrydnikDataGridView.Rows[index].Visible = false;

            if (SotrydnikDataGridView.Rows[index].Cells[0].Value.ToString() != String.Empty)
            {
                SotrydnikDataGridView.Rows[index].Cells[2].Value = Sostoyanie.deleted;


            }
        }

        private void SotrydnikIzmenitBtn_Click(object sender, EventArgs e)
        {
            Izmenit();
        }

        private void Izmenit()
        {
            int index = SotrydnikDataGridView.CurrentCell.RowIndex;

            int kodSotrydnika;
            string FIOSOtrydnika = FIOSotrydnikaTxtBx.Text;

            if (SotrydnikDataGridView.Rows[index].Cells[0].Value.ToString() != String.Empty)
            {
                if (int.TryParse(KodSotrydnikaTxtBx.Text, out kodSotrydnika))
                {
                    SotrydnikDataGridView.Rows[index].SetValues(kodSotrydnika, FIOSOtrydnika);

                    SotrydnikDataGridView.Rows[index].Cells[2].Value = Sostoyanie.modified;


                }
                else
                {
                    MessageBox.Show("Поле 'Код сотрудника' должно содержать числовое значение. ", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void SotrydnikDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (selectedRow >= 0)
            {
                DataGridViewRow row = SotrydnikDataGridView.Rows[selectedRow];

                KodSotrydnikaTxtBx.Text = row.Cells[0].Value.ToString();
                FIOSotrydnikaTxtBx.Text = row.Cells[1].Value.ToString();

            }
        }

        private void SotrydnikNovaBtn_Click(object sender, EventArgs e)
        {
            DobavitSotrydnik dobavit = new DobavitSotrydnik();
            dobavit.ShowDialog();
        }

        private void RefresherOrbBtn_Click(object sender, EventArgs e)
        {
            ObnovitTable(SotrydnikDataGridView);
        }

        private void SotrydnikSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            Posik(SotrydnikDataGridView);
        }

        private void Posik(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            string PoiskZapros = $"select * from Сотрудник where concat (КодСотрудника, ФИОСотрудника) like '%" + SotrydnikSearchTxtBox.Text + "%'";

            SqlCommand command = new SqlCommand(PoiskZapros, dbCon.getConnection());

            dbCon.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView, reader);


            }

            reader.Close();
        }
    }
}

