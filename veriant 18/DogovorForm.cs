using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriant_18
{
    public partial class DogovorForm : Form
    {
        database__connect dbCon = new database__connect();
        public DogovorForm()
        {
            InitializeComponent();
            DogovorDataGridView.AllowUserToAddRows = false;
        }

        private int selectedRow;

        private void CreateTable()
        {
            DogovorDataGridView.Columns.Add("Nomer dogovora", "Номер договора");
            DogovorDataGridView.Columns.Add("Data zaklycheniya dogovora", "Дата заключения договора");
            DogovorDataGridView.Columns.Add("Nomer KP", "Номер КП");
            DogovorDataGridView.Columns.Add("Kod postavshika", "Код поставщика");
            DogovorDataGridView.Columns.Add("Kod tovara", "Код товара");
            DogovorDataGridView.Columns.Add("Kod sotrydnika", "Код сотрудника");
            DogovorDataGridView.Columns.Add("Stoimost postavki", "Стоимомость поставки");
            DogovorDataGridView.Columns.Add("Kolichestvo postavki", "Количество поставки");
            DogovorDataGridView.Columns.Add("Sostoyanie", String.Empty);

            DogovorDataGridView.Columns["Sostoyanie"].Visible = false;
            DogovorDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetDateTime(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), record.GetInt32(5), record.GetDecimal(6), record.GetInt32(7), Sostoyanie.exsisted);
        }

        private void ObnovitTable(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryAdd = "Select * From Договор";
            dbCon.openConnection();

            SqlCommand command = new SqlCommand(queryAdd, dbCon.getConnection());

            IDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }

            reader.Close();
        }

        private void DogovorForm_Load(object sender, EventArgs e)
        {
            if (DogovorDataGridView.Rows.Count == 0)
            {
                CreateTable();
            }
            ObnovitTable(DogovorDataGridView);
            FormatDate(DogovorDataGridView);
        }

        private void Sohranit()
        {
            dbCon.openConnection();

            for (int index = 0; index < DogovorDataGridView.Rows.Count; index++)
            {
                Sostoyanie rowState = (Sostoyanie)DogovorDataGridView.Rows[index].Cells[8].Value;

                if (rowState == Sostoyanie.deleted)
                {
                    int dogovorNumber = Convert.ToInt32(DogovorDataGridView.Rows[index].Cells[0].Value);

                    string queryDelete = $"Delete From Договор Where НомерДоговора = {dogovorNumber}";

                    SqlCommand command = new SqlCommand(queryDelete, dbCon.getConnection());

                    command.ExecuteNonQuery();
                }
                if (rowState == Sostoyanie.modified)
                {
                    int nomerDogovora = Convert.ToInt32(DogovorDataGridView.Rows[index].Cells[0].Value); 
                    DateTime dataZaklycheniya = Convert.ToDateTime(DogovorDataGridView.Rows[index].Cells[1].Value);
                    int nomerKP = Convert.ToInt32(DogovorDataGridView.Rows[index].Cells[2].Value);
                    int kodPostavshika = Convert.ToInt32(DogovorDataGridView.Rows[index].Cells[3].Value);
                    int kodTovara = Convert.ToInt32(DogovorDataGridView.Rows[index].Cells[4].Value);
                    int kodSotrydnika = Convert.ToInt32(DogovorDataGridView.Rows[index].Cells[5].Value);
                    decimal stoimostPost = Convert.ToDecimal(DogovorDataGridView.Rows[index].Cells[6].Value);
                    int kolichestvoPost = Convert.ToInt32(DogovorDataGridView.Rows[index].Cells[7].Value);


                    string modifyQuery = "Update Договор Set НомерКП = @nomerKP, КодПоставщика = @kodPostavshika, КодТовара = @kodTovara, КодСотрудника = @kodSotrydnika, ДатаЗаключения = @dataZaklycheniya, СтоимостьПоставки = @stoimostPost, КоличествоПоставки = @kolichestvoPost Where НомерДоговора = @nomerDogovora";

                    SqlCommand command = new SqlCommand(modifyQuery, dbCon.getConnection());

                    command.Parameters.AddWithValue("@nomerDogovora", nomerDogovora);
                    command.Parameters.AddWithValue("@nomerKP", nomerKP);
                    command.Parameters.AddWithValue("@kodPostavshika", kodPostavshika);
                    command.Parameters.AddWithValue("@kodTovara", kodTovara);
                    command.Parameters.AddWithValue("@kodSotrydnika", kodSotrydnika);
                    command.Parameters.AddWithValue("@dataZaklycheniya", dataZaklycheniya);
                    command.Parameters.AddWithValue("@stoimostPost", stoimostPost);
                    command.Parameters.AddWithValue("@kolichestvoPost", kolichestvoPost);

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
            int index = DogovorDataGridView.CurrentCell.RowIndex;

            DogovorDataGridView.Rows[index].Visible = false;

            if (DogovorDataGridView.Rows[index].Cells[0].Value.ToString() != String.Empty)
            {
                DogovorDataGridView.Rows[index].Cells[8].Value = Sostoyanie.deleted;
                return;
            }
        }

        private void Izmenit()
        {
            int index = DogovorDataGridView.CurrentCell.RowIndex;

            int nomerDogovora;
            int nomerKP = Convert.ToInt32(NomerKPTxtBx.Text);
            int kodPostavshika = Convert.ToInt32(KodPostTxtBx.Text);
            int kodTovara = Convert.ToInt32(KodTovaraTxtBx.Text);
            int kodSotrydnika = Convert.ToInt32(KodSotrydnikaTxtBx.Text);
            DateTime dataZaklycheniya = Convert.ToDateTime(DataZaclychTxtBx.Text);
            decimal stoimostPost = Convert.ToDecimal(StoimostPostTxtBx.Text);
            int kolichestvoPost = Convert.ToInt32(KolichestvoPostTxtBx.Text);


            if (DogovorDataGridView.Rows[index].Cells[0].Value.ToString() != String.Empty)
            {
                if (int.TryParse(NomerDogovoraTxtBx.Text, out nomerDogovora))
                {
                    DogovorDataGridView.Rows[index].SetValues(nomerDogovora, dataZaklycheniya, nomerKP, kodPostavshika, kodTovara, kodSotrydnika, stoimostPost, kolichestvoPost);

                    DogovorDataGridView.Rows[index].Cells[8].Value = Sostoyanie.modified;
                }
                else
                {
                    MessageBox.Show("Поле 'Номер договора' должно содержать числовое значение. ", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string searchQuerry = $"Select * From Договор Where Concat (НомерДоговора ,НомерКП ,КодПоставщика ,КодТовара ,КодСотрудника, ДатаЗаключения, СтоимостьПоставки, КоличествоПоставки) like '%" + DogovorSearchTxtBox.Text + "%'";

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
            ObnovitTable(DogovorDataGridView);
        }

        private void UdalitBtn_Click(object sender, EventArgs e)
        {
            Udalit();
        }

        private void IzmenitBtn_Click(object sender, EventArgs e)
        {
            Izmenit();
        }

        private void DogovorDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (selectedRow >= 0)
            {
                DataGridViewRow row = DogovorDataGridView.Rows[selectedRow];

                NomerDogovoraTxtBx.Text = row.Cells[0].Value.ToString();
                DateTime agreementDate = Convert.ToDateTime(row.Cells[1].Value);
                DataZaclychTxtBx.Text = agreementDate.ToString("dd.MM.yyyy");
                NomerKPTxtBx.Text = row.Cells[2].Value.ToString();
                KodPostTxtBx.Text = row.Cells[3].Value.ToString();
                KodTovaraTxtBx.Text = row.Cells[4].Value.ToString();
                KodSotrydnikaTxtBx.Text = row.Cells[5].Value.ToString();
                StoimostPostTxtBx.Text = row.Cells[6].Value.ToString();
                KolichestvoPostTxtBx.Text = row.Cells[7].Value.ToString();

                
            }
        }

        private void DogovorSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            Search(DogovorDataGridView);
        }

        private void DogovorNovaBtn_Click(object sender, EventArgs e)
        {
            DobavitDogovor dobavit = new DobavitDogovor();
           dobavit.ShowDialog();
        }

        private void FormatDate(DataGridView dgv)
        {
            dgv.Columns[1].DefaultCellStyle.Format = "dd.MM.yyyy";
        }
    }
}
