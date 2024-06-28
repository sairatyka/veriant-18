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
    public partial class DobavitPostavshik : Form
    {
        database__connect dbCon = new database__connect();
        
        public DobavitPostavshik()
        {
            InitializeComponent();
        }

        private void DobavitBTN_Click(object sender, EventArgs e)
        {
            dbCon.openConnection();

            string NazvanieOrganizaciy = NazvanieOrganTXTBX.Text;
            int KodPostavshika;

            if (int.TryParse(KodPostavshikaTXTBX.Text, out KodPostavshika))
            {
                string DobavitZapros = $"insert into Поставщик (КодПоставщика, НазваниеОрганизации) values ('{KodPostavshika}', '{NazvanieOrganizaciy}')";

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
