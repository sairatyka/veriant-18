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
    public partial class DobavitDogovor : Form
    {
        database__connect dbCon = new database__connect();
        public DobavitDogovor()
        {
            InitializeComponent();
        }

        private void DobavitBTN_Click(object sender, EventArgs e)
        {
            dbCon.openConnection();

            int nomerDogovora = Convert.ToInt32(NomerDogovoraTXTBX.Text);
            int nomerKP = Convert.ToInt32(NomerKPTXTBX.Text);
            int kodPOst = Convert.ToInt32(KodPOstTxtBx.Text);
            int kodTovara = Convert.ToInt32(KodTovaraTxtBx.Text);
            int kodSotrydnika = Convert.ToInt32(KodSotrydnikaTxtBx.Text);
            DateTime DateTimePicker = Convert.ToDateTime(dateTimePicker.Value);
            int stoimostPost = Convert.ToInt32(StoimostPostTxtBx.Text);
            int kolichestvoPost = Convert.ToInt32(KolichestvoPostTxtBx.Text);

            string addQuery = "Insert Into Договор (НомерДоговора ,НомерКП ,КодПоставщика ,КодТовара ,КодСотрудника, ДатаЗаключения, СтоимостьПоставки, КоличествоПоставки) Values (@nomerDogovora, @nomerKP, @kodPOst, @kodTovara, @kodSotrydnika, @DateTimePicker, @stoimostPost, @kolichestvoPost)";

            SqlCommand command = new SqlCommand(addQuery, dbCon.getConnection());

            command.Parameters.AddWithValue("@nomerDogovora", nomerDogovora);
            command.Parameters.AddWithValue("@nomerKP", nomerKP);
            command.Parameters.AddWithValue("@kodPOst", kodPOst);
            command.Parameters.AddWithValue("@kodTovara", kodTovara);
            command.Parameters.AddWithValue("@kodSotrydnika", kodSotrydnika);
            command.Parameters.Add("@DateTimePicker", SqlDbType.Date).Value = DateTimePicker;
            command.Parameters.Add("@stoimostPost", SqlDbType.Decimal).Value = stoimostPost;
            command.Parameters.AddWithValue("@kolichestvoPost", kolichestvoPost);


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

        private void DobavitDogovor_Load(object sender, EventArgs e)
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd MM yyyy";
        }
    }

}
