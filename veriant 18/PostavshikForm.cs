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
    public enum Sostoyanie
    {
        exsisted,
        modified,
        deleted
    }

    public partial class PostavshikForm : Form
    {

        database__connect dbCon = new database__connect();

        public PostavshikForm()
        {
            InitializeComponent();
            PostavshikDataGridView.AllowUserToAddRows = false;
        }

        private int selectedRow;

        public void SozdatStolb()
        {
            PostavshikDataGridView.Columns.Add("Kod postavshika", "Код поставщика");
            PostavshikDataGridView.Columns.Add("Nazvanie organizacii", "Название организации");
            PostavshikDataGridView.Columns.Add("Sostoyanie", String.Empty);

            PostavshikDataGridView.Columns["Sostoyanie"].Visible = false;

            PostavshikDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void ReadSingleRow(DataGridView dataGridView, IDataRecord record)
        {
            dataGridView.Rows.Add(record.GetInt32(0), record.GetString(1), Sostoyanie.exsisted); 
        }

        public void ObnovitTable(DataGridView dataGridView)
        {


            PostavshikDataGridView.Rows.Clear();

            dbCon.openConnection();

            string Zapros = "Select * From Поставщик";

            SqlCommand command = new SqlCommand(Zapros, dbCon.getConnection());

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView, reader);
            }

            reader.Close();
        }

        private void PostavshikForm_Load(object sender, EventArgs e)
        {
            if (PostavshikDataGridView.Rows.Count == 0)
            {
                SozdatStolb();
            }

            ObnovitTable(PostavshikDataGridView);
        }

        private void PostavshikSohranitBtn_Click(object sender, EventArgs e)
        {
            Sohranit();
        }

        private void Sohranit()
        {
            dbCon.openConnection();

            for (int index = 0; index < PostavshikDataGridView.Rows.Count; index++)
            {
                Sostoyanie sostoyanie = (Sostoyanie)PostavshikDataGridView.Rows[index].Cells[2].Value;

                if (sostoyanie == Sostoyanie.deleted)
                {
                    int KodPostavshika = Convert.ToInt32(PostavshikDataGridView.Rows[index].Cells[0].Value);

                    string UdalitZapros = $"Delete from Поставщик where КодПоставщика = {KodPostavshika}";

                    SqlCommand command = new SqlCommand(UdalitZapros, dbCon.getConnection());

                    command.ExecuteNonQuery();
                }

                if (sostoyanie == Sostoyanie.modified)
                {
                    int KodPostavshika = Convert.ToInt32(KodPostavshikaTxtBx.Text);
                    string NAzvanieOrganizaciy = NazvanieOrganTxtBx.Text;

                    string IzmenitZapros = "Update Поставщик Set НазваниеОрганизации = @nazvanieOrganizaciy where КодПоставщика = @kodPostavshika";

                    SqlCommand command = new SqlCommand(IzmenitZapros, dbCon.getConnection());

                    command.Parameters.AddWithValue("@kodPostavshika", KodPostavshika);
                    command.Parameters.AddWithValue("@nazvanieOrganizaciy", NAzvanieOrganizaciy);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно обновлена", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show($"Произошла ошибка: {ex.Message}", "ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            
            dbCon.closeConnection();
        }

        private void PostavshikUdalitBtn_Click(object sender, EventArgs e)
        {
            Udalit();
        }

        private void Udalit()
        {
            int index = PostavshikDataGridView.CurrentCell.RowIndex;

            PostavshikDataGridView.Rows[index].Visible = false;

            if (PostavshikDataGridView.Rows[index].Cells[0].Value.ToString() != String.Empty)
            {
                PostavshikDataGridView.Rows[index].Cells[2].Value = Sostoyanie.deleted;

               
            }
        }

        private void PostavshikIzmenitBtn_Click(object sender, EventArgs e)
        {
            Izmenit();
        }

        private void Izmenit()
        {
            int index = PostavshikDataGridView.CurrentCell.RowIndex;

            int kodPostavshika;
            string nazvanieOrganizaciy = NazvanieOrganTxtBx.Text;

            if (PostavshikDataGridView.Rows[index].Cells[0].Value.ToString() != String.Empty)
            {
                if (int.TryParse(KodPostavshikaTxtBx.Text, out kodPostavshika))
                {
                    PostavshikDataGridView.Rows[index].SetValues(kodPostavshika, nazvanieOrganizaciy);

                    PostavshikDataGridView.Rows[index].Cells[2].Value = Sostoyanie.modified;


                }
                else
                {
                    MessageBox.Show("Поле 'Код поставщика' должно содержать числовое значение. ", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void PostavshikDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (selectedRow >= 0) 
            {
                DataGridViewRow row = PostavshikDataGridView.Rows[selectedRow];

                KodPostavshikaTxtBx.Text = row.Cells[0].Value.ToString();
                NazvanieOrganTxtBx.Text = row.Cells[1].Value.ToString();

            }
        }

        private void PostavshikNovaBtn_Click(object sender, EventArgs e)
        {
            DobavitPostavshik dobavit = new DobavitPostavshik();
            dobavit.ShowDialog();
        }

        private void RefresherOrbBtn_Click(object sender, EventArgs e)
        {
            ObnovitTable(PostavshikDataGridView);
        }

        private void PostavshikSearchTxtBox_TextChanged(object sender, EventArgs e)
        {
            Posik(PostavshikDataGridView);
        }

        private void Posik(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            string PoiskZapros = $"select * from Поставщик where concat (КодПоставщика, НазваниеОрганизации) like '%" + PostavshikSearchTxtBox.Text + "%'";

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
