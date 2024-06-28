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
    public partial class KomPredlozhFrom : Form
    {
        database__connect dbCon = new database__connect();
        public KomPredlozhFrom()
        {
            InitializeComponent();
            KomDataGridView.AllowUserToAddRows = false;
        }

        private int selectedRow;

        private void CreateTable()
        {
            KomDataGridView.Columns.Add("Nomer KP", "Номер КП");
            KomDataGridView.Columns.Add("Data KP", "Дата КП");
            KomDataGridView.Columns.Add("Kod postavshika", "Код поставщика");
            KomDataGridView.Columns.Add("Kod tovara", "Код товара");
            KomDataGridView.Columns.Add("Kolichestvo tovara", "Количество товара");
            KomDataGridView.Columns.Add("Tsena tovara", "Цена товара");
            KomDataGridView.Columns.Add("Sostoyanie", String.Empty);


            KomDataGridView.Columns["Sostoyanie"].Visible = false;
            KomDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetDateTime(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), record.GetDecimal(5), Sostoyanie.exsisted);
        }

        private void ObnovitTable(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryAdd = "Select * From КоммерческоеПредложение";
            dbCon.openConnection();

            SqlCommand command = new SqlCommand(queryAdd, dbCon.getConnection());

            IDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }

            reader.Close();
        }

        private void KomForm_Load(object sender, EventArgs e)
        {
            if (KomDataGridView.Rows.Count == 0)
            {
                CreateTable();
            }
            ObnovitTable(KomDataGridView);
            FormatDate(KomDataGridView);
        }

        private void Sohranit()
        {
            dbCon.openConnection();

            for (int index = 0; index < KomDataGridView.Rows.Count; index++)
            {
                Sostoyanie rowState = (Sostoyanie)KomDataGridView.Rows[index].Cells[6].Value;

                if (rowState == Sostoyanie.deleted)
                {
                    int KPNumber = Convert.ToInt32(KomDataGridView.Rows[index].Cells[0].Value);

                    string queryDelete = $"Delete From КоммерческоеПредложение Where НомерКП = {KPNumber}";

                    SqlCommand command = new SqlCommand(queryDelete, dbCon.getConnection());

                    command.ExecuteNonQuery();
                }
                if (rowState == Sostoyanie.modified)
                {
       
                    DateTime dataKP = Convert.ToDateTime(KomDataGridView.Rows[index].Cells[1].Value);
                    int nomerKP = Convert.ToInt32(KomDataGridView.Rows[index].Cells[0].Value);
                    int kodPostavshika = Convert.ToInt32(KomDataGridView.Rows[index].Cells[2].Value);
                    int kodTovara = Convert.ToInt32(KomDataGridView.Rows[index].Cells[3].Value);
                    decimal tsenaTovara = Convert.ToDecimal(KomDataGridView.Rows[index].Cells[5].Value);
                    int kolichestvoTovara = Convert.ToInt32(KomDataGridView.Rows[index].Cells[4].Value);


                    string modifyQuery = "Update КоммерческоеПредложение Set КодПоставщика = @kodPostavshika, КодТовара = @kodTovara, ДатаКП = @dataKP, ЦенаТовара = @tsenaTovara, КоличествоТовара = @kolichestvoTovara Where НомерКП = @nomerKP";

                    SqlCommand command = new SqlCommand(modifyQuery, dbCon.getConnection());

                    command.Parameters.AddWithValue("@nomerKP", nomerKP);
                    command.Parameters.AddWithValue("@kodPostavshika", kodPostavshika);
                    command.Parameters.AddWithValue("@kodTovara", kodTovara);
                    command.Parameters.AddWithValue("@dataKP", dataKP);
                    command.Parameters.AddWithValue("@tsenaTovara", tsenaTovara);
                    command.Parameters.AddWithValue("@kolichestvoTovara", kolichestvoTovara);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно обновлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Произошла непридвиденная ошибка: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void Udalit()
        {
            int index = KomDataGridView.CurrentCell.RowIndex;

            KomDataGridView.Rows[index].Visible = false;

            if (KomDataGridView.Rows[index].Cells[0].Value.ToString() != String.Empty)
            {
                KomDataGridView.Rows[index].Cells[6].Value = Sostoyanie.deleted;
                return;
            }
        }

        private void Izmenit()
        {
            int index = KomDataGridView.CurrentCell.RowIndex;

            int nomerKP;
            DateTime dataZaklycheniya = Convert.ToDateTime(DataZaclychTxtBx.Text);
            int kodPostavshika = Convert.ToInt32(KodPostTxtBx.Text);
            int kodTovara = Convert.ToInt32(KodTovaraTxtBx.Text);          
            decimal tsenaTovara = Convert.ToDecimal(TsenaTovaraTxtBx.Text);
            int kolichestvoTovara = Convert.ToInt32(KolichestvoTovaraTxtBx.Text);


            if (KomDataGridView.Rows[index].Cells[0].Value.ToString() != String.Empty)
            {
                if (int.TryParse(NomerKPTxtBx.Text, out nomerKP))
                {
                    KomDataGridView.Rows[index].SetValues(nomerKP, dataZaklycheniya, kodPostavshika, kodTovara,  kolichestvoTovara, tsenaTovara);

                    KomDataGridView.Rows[index].Cells[6].Value = Sostoyanie.modified;
                }
                else
                {
                    MessageBox.Show("Поле 'Номер КП' должно содержать числовое значение. ", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string searchQuerry = $"Select * From КоммерческоеПредложение Where Concat (НомерКП ,КодПоставщика ,КодТовара , ДатаКП, ЦенаТовара, КоличествоТовара) like '%" + KomSearchTxtBox.Text + "%'";

            SqlCommand command = new SqlCommand(searchQuerry, dbCon.getConnection());

            dbCon.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }

            reader.Close();
        }

        private void SohranitBtn_Click(object sender, EventArgs e)
        {
            Sohranit();
        }

        private void RefresherOrbBtn_Click(object sender, EventArgs e)
        {
            ObnovitTable(KomDataGridView);
        }

        private void UdalitBtn_Click(object sender, EventArgs e)
        {
            Udalit();
        }

        private void IzmenitBtn_Click(object sender, EventArgs e)
        {
            Izmenit();
        }

        private void KomDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (selectedRow >= 0)
            {
                DataGridViewRow row = KomDataGridView.Rows[selectedRow];

                DateTime agreementDate = Convert.ToDateTime(row.Cells[1].Value);
                DataZaclychTxtBx.Text = agreementDate.ToString("dd.MM.yyyy");
                NomerKPTxtBx.Text = row.Cells[0].Value.ToString();
                KodPostTxtBx.Text = row.Cells[2].Value.ToString();
                KodTovaraTxtBx.Text = row.Cells[3].Value.ToString();
                KolichestvoTovaraTxtBx.Text = row.Cells[4].Value.ToString();
                TsenaTovaraTxtBx.Text = row.Cells[5].Value.ToString();


            }
        }

        private void KomSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            Search(KomDataGridView);
        }

        private void KomNovaBtn_Click(object sender, EventArgs e)
        {
            DobavitKomPredolzh dobavitKomPredolzh = new DobavitKomPredolzh();
            dobavitKomPredolzh.ShowDialog();
        }

        private void FormatDate(DataGridView dgv)
        {
            dgv.Columns[1].DefaultCellStyle.Format = "dd.MM.yyyy";
        }
    }
}
