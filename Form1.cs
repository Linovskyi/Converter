using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Web;
using System.Net;
using System.IO;


namespace CurrencyLib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            string date = dtpCurrencyDate.Value.ToString("yyyyMMdd");
            string URI = $"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?date={date}&amp;json";
            string webResponseString;

            WebRequest request = WebRequest.Create(URI);
            request.Method = WebRequestMethods.Http.Get;
            using (WebResponse response = request.GetResponse())
            {
                using (Stream dataStream = response.GetResponseStream())
                {
                    StreamReader streamRdr = new StreamReader(dataStream);
                    webResponseString = streamRdr.ReadToEnd();
                }
            };

            List<CurrencyRate> currRates = JsonConvert.DeserializeObject<List<CurrencyRate>>(webResponseString);
            listViewCurrates.Items.Clear();

            foreach (var item in currRates)
            {
                listViewCurrates.Items.Add(new ListViewItem(item.ToStringArray()));
            }
        }

        private void dtpCurrencyDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
