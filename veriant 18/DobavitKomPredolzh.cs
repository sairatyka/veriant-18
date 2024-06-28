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
    public partial class DobavitKomPredolzh : Form
    {
        database__connect dbCon = new database__connect();
        public DobavitKomPredolzh()
        {
            InitializeComponent();
        }

        private void DobavitBTN_Click(object sender, EventArgs e)
        {
            dbCon.openConnection();

            int nomerKP = Convert.ToInt32(NomerKPTXTBX.Text);
            int kodPOst = Convert.ToInt32(KodPOstTxtBx.Text);
            int kodTovara = Convert.ToInt32(KodTovaraTxtBx.Text);
            DateTime DateTimePicker = Convert.ToDateTime(dateTimePicker.Value);
            int tsenaTovara = Convert.ToInt32(TsenaTovaraTxtBx.Text);
            int kolichestvoTovara = Convert.ToInt32(KolichestvoTovaraTxtBx.Text);

            string addQuery = "Insert Into КоммерческоеПредложение (НомерКП ,КодПоставщика ,КодТовара , ДатаКП, ЦенаТовара, КоличествоТовара) Values (@nomerKP, @kodPOst, @kodTovara, @DateTimePicker, @tsenaTovara, @kolichestvoTovara)";

            SqlCommand command = new SqlCommand(addQuery, dbCon.getConnection());


            command.Parameters.AddWithValue("@nomerKP", nomerKP);
            command.Parameters.AddWithValue("@kodPOst", kodPOst);
            command.Parameters.AddWithValue("@kodTovara", kodTovara);

            command.Parameters.Add("@DateTimePicker", SqlDbType.Date).Value = DateTimePicker;
            command.Parameters.Add("@tsenaTovara", SqlDbType.Decimal).Value = tsenaTovara;
            command.Parameters.AddWithValue("@kolichestvoTovara", kolichestvoTovara);


            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла непредвиденная ошибка: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbCon.closeConnection();
            }
        }
        private void DobavitKom_Load(object sender, EventArgs e)
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd MM yyyy";
        }
    }
}
