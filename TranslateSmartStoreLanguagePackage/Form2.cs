using Google.Apis.Auth.OAuth2;
using Google.Cloud.Translation.V2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace TranslateSmartStoreLanguagePackage
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var credential = GoogleCredential.FromStream(new FileStream("Business Innovators - Store-Translation.json", FileMode.Open))
            //        .CreateScoped(new string[] { StorageService.Scope.DevstorageReadOnly });


            TranslationClient client = TranslationClient.Create();
            var response = client.TranslateText(textBox1.Text, "ar", "en");
            textBox2.Text = response.TranslatedText;



            //string url = "https://translation.googleapis.com/language/translate/v2?key=YOUR_API_KEY";
            //url += "&source=en&target=ar&q=" + textBox1.Text.Trim();
            //WebClient client = new WebClient();
            //string json = client.DownloadString(url);
            //JsonData jsonData = (new JavaScriptSerializer()).Deserialize<JsonData>(json);
            //textBox2.Text = jsonData.Data.Translations[0].TranslatedText;
        }


        public class JsonData
        {
            public Data Data { get; set; }
        }
        public class Data
        {
            public List<Translation> Translations { get; set; }
        }
        public class Translation
        {
            public string TranslatedText { get; set; }
        }
    }
}
