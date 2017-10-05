using RavSoft.GoogleTranslator;
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

namespace TranslateSmartStoreLanguagePackage
{
    public partial class Form1 : Form
    {
        string connectionString;
        string queryString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workingDataBaseDataSet.EnglishLanguagePackage' table. You can move, or remove it, as needed.
            this.englishLanguagePackageTableAdapter.Fill(this.workingDataBaseDataSet.EnglishLanguagePackage);

            connectionString = @"Data Source=MKHAFAGY-PC;Initial Catalog=WorkingDataBase;Integrated Security=true";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Translator t = new Translator();
            string ItemKey = "", EnglishText = "", ArabicText = "";
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            foreach (DataRow dr in this.workingDataBaseDataSet.EnglishLanguagePackage.Rows)
            {
                ItemKey = EnglishText = ArabicText = "";
                ItemKey = dr["ItemKey"].ToString();
                EnglishText = dr["EnglishText"].ToString();

                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    ArabicText = t.Translate(EnglishText, "English", "Arabic");


                    queryString = "UPDATE [dbo].[EnglishLanguagePackage] SET [ArabicText] = (N'{0}') WHERE [ItemKey] ='{1}'";
                    queryString = string.Format(queryString, ArabicText, ItemKey);
                    command = new SqlCommand(queryString, connection);
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                connection.Close();

            }
        }
    }
}
