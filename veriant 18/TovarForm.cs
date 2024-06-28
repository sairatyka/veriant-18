using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace veriant_18
{
    public partial class TovarForm : Form
    {
        database__connect dbCon = new database__connect();
        public TovarForm()
        {
            InitializeComponent();
            TovarDataGridView.AllowUserToAddRows = false;
        }

        private int selectedRow;

        public void SozdatStolb()
        {
            TovarDataGridView.Columns.Add("Kod tovara", "Код товара");
            TovarDataGridView.Columns.Add("Nazvanie tovara", "Название товара");
            TovarDataGridView.Columns.Add("Sostoyanie", String.Empty);

            TovarDataGridView.Columns["Sostoyanie"].Visible = false;

            TovarDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void ReadSingleRow(DataGridView dataGridView, IDataRecord record)
        {
            dataGridView.Rows.Add(record.GetInt32(0), record.GetString(1), Sostoyanie.exsisted);
        }

        public void ObnovitTable(DataGridView dataGridView)
        {


            TovarDataGridView.Rows.Clear();

            dbCon.openConnection();

            string Zapros = "Select * From Товар ";

            SqlCommand command = new SqlCommand(Zapros, dbCon.getConnection());

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView, reader);
            }

            reader.Close();
        }

        private void TovarForm_Load(object sender, EventArgs e)
        {
            if (TovarDataGridView.Rows.Count == 0)
            {
                SozdatStolb();
            }

            ObnovitTable(TovarDataGridView);
        }

        private void TovarSohranitBtn_Click(object sender, EventArgs e)
        {
            Sohranit();
        }

        private void Sohranit()
        {
            dbCon.openConnection();

            for (int index = 0; index < TovarDataGridView.Rows.Count; index++)
            {
                Sostoyanie sostoyanie = (Sostoyanie)TovarDataGridView.Rows[index].Cells[2].Value;

                if (sostoyanie == Sostoyanie.deleted)
                {
                    int KodTovara = Convert.ToInt32(TovarDataGridView.Rows[index].Cells[0].Value);

                    string UdalitZapros = $"Delete from Товар where КодТовара = {KodTovara}";

                    SqlCommand command = new SqlCommand(UdalitZapros, dbCon.getConnection());

                    command.ExecuteNonQuery();
                }

                if (sostoyanie == Sostoyanie.modified)
                {
                    int KodTovara = Convert.ToInt32(KodTovaraTxtBx.Text);
                    string NazvanieTovara = NazvanieTovaraTxtBx.Text;

                    string IzmenitZapros = "Update Товар Set НазваниеТовара = @nazvanieTovara where КодТовара = @kodTovara";

                    SqlCommand command = new SqlCommand(IzmenitZapros, dbCon.getConnection());

                    command.Parameters.AddWithValue("@kodTovara", KodTovara);
                    command.Parameters.AddWithValue("@nazvanieTovara", NazvanieTovara);

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

        private void TovarUdalitBtn_Click(object sender, EventArgs e)
        {
            Udalit();
        }

        private void Udalit()
        {
            int index = TovarDataGridView.CurrentCell.RowIndex;

            TovarDataGridView.Rows[index].Visible = false;

            if (TovarDataGridView.Rows[index].Cells[0].Value.ToString() != String.Empty)
            {
                TovarDataGridView.Rows[index].Cells[2].Value = Sostoyanie.deleted;


            }
        }

        private void TovarIzmenitBtn_Click(object sender, EventArgs e)
        {
            Izmenit();
        }

        private void Izmenit()
        {
            int index = TovarDataGridView.CurrentCell.RowIndex;

            int kodTovara;
            string nazvanieTovara = NazvanieTovaraTxtBx.Text;

            if (TovarDataGridView.Rows[index].Cells[0].Value.ToString() != String.Empty)
            {
                if (int.TryParse(KodTovaraTxtBx.Text, out kodTovara))
                {
                    TovarDataGridView.Rows[index].SetValues(kodTovara, nazvanieTovara);

                    TovarDataGridView.Rows[index].Cells[2].Value = Sostoyanie.modified;


                }
                else
                {
                    MessageBox.Show("Поле 'Код товара' должно содержать числовое значение. ", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void TovarDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (selectedRow >= 0)
            {
                DataGridViewRow row = TovarDataGridView.Rows[selectedRow];

                KodTovaraTxtBx.Text = row.Cells[0].Value.ToString();
                NazvanieTovaraTxtBx.Text = row.Cells[1].Value.ToString();

            }
        }

        private void TovarNovaBtn_Click(object sender, EventArgs e)
        {
            DobavitTovar dobavit = new DobavitTovar();
            dobavit.ShowDialog();
        }

        private void RefresherOrbBtn_Click(object sender, EventArgs e)
        {
            ObnovitTable(TovarDataGridView);
        }

        private void TovarSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            Posik(TovarDataGridView);
        }

        private void Posik(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            string PoiskZapros = $"select * from Товар where concat (КодТовара, НазваниеТовара) like '%" + TovarSearchTxtBox.Text + "%'";

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

    

