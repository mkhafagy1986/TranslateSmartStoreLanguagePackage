using Google.Cloud.Translation.V2;
using RavSoft.GoogleTranslator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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
            // TODO: This line of code loads data into the 'workingDataBaseDataSet1.EnglishLanguagePackage' table. You can move, or remove it, as needed.
            this.englishLanguagePackageTableAdapter1.Fill(this.workingDataBaseDataSet1.EnglishLanguagePackage);

            connectionString = @"Data Source=MKHAFAGY-PC;Initial Catalog=WorkingDataBase;Integrated Security=true";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Translator t = new Translator();
            string ItemKey = "", EnglishText = "", ArabicText = "";
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            TranslationClient client = TranslationClient.Create();
            foreach (DataRow dr in this.workingDataBaseDataSet.EnglishLanguagePackage.Rows)
            {
                ItemKey = EnglishText = ArabicText = "";
                ItemKey = dr["ItemKey"].ToString();
                EnglishText = dr["EnglishText"].ToString();

                try
                {
                    var response = client.TranslateText(EnglishText, "ar", "en");
                    ArabicText = response.TranslatedText;
                    ArabicText = ArabicText.Replace("'", "''");
                    //this.Cursor = Cursors.WaitCursor;
                    //ArabicText = t.Translate(EnglishText, "English", "Arabic");


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

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT [ItemKey] AS 'Name',[Value] FROM [dbo].[EnglishLanguagePackage]";

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            using (SqlCommand _cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                dt.Load(_cmd.ExecuteReader());
                connection.Close();
            }

            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);

            XmlNode LanguageRootNode = doc.CreateElement("Language");
            XmlAttribute NameAttribute = doc.CreateAttribute("Name");
            NameAttribute.Value = "Arabic";
            LanguageRootNode.Attributes.Append(NameAttribute);
            doc.AppendChild(LanguageRootNode);

            foreach (DataRow item in dt.Rows)
            {
                XmlNode LocaleResourceNode = doc.CreateElement("LocaleResource");
                XmlAttribute LocaleResourceNameAttribute = doc.CreateAttribute("Name");
                LocaleResourceNameAttribute.Value = item[0].ToString();
                LocaleResourceNode.Attributes.Append(LocaleResourceNameAttribute);
                LanguageRootNode.AppendChild(LocaleResourceNode);

                XmlNode ValueNode = doc.CreateElement("Value");
                ValueNode.AppendChild(doc.CreateTextNode(item[1].ToString()));
                LocaleResourceNode.AppendChild(ValueNode);
            }
            doc.Save(@"C:\Users\mkhafagy.c\source\repos\TranslateSmartStoreLanguagePackage\TranslateSmartStoreLanguagePackage\Data\language-pack-ar.xml");
        }
    }
}
