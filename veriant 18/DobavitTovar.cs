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
    public partial class DobavitTovar : Form
    {
        database__connect dbCon = new database__connect();

        public DobavitTovar()
        {
            InitializeComponent();
        }

        private void DobavitBTN_Click(object sender, EventArgs e)
        {
            dbCon.openConnection();

            string NazvanieTovara = NazvanieTovaraTXTBX.Text;
            int KodTovara;

            if (int.TryParse(KodTovaraTXTBX.Text, out KodTovara))
            {
                string DobavitZapros = $"insert into Поставщик (КодПоставщика, НазваниеОрганизации) values ('{KodTovara}', '{NazvanieTovara}')";

                SqlCommand command = new SqlCommand(DobavitZapros, dbCon.getConnection());

                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Поле Код поставщика должно быть числом!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
