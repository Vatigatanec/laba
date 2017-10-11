using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Json;

namespace laba1
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void Get_Data_Click(object sender, EventArgs e)
        {
            string HtmlText = "";
            HttpWebRequest myHttwebrequest = (HttpWebRequest)HttpWebRequest.Create(URL.Text);
            HttpWebResponse myHttpWebresponse = (HttpWebResponse)myHttwebrequest.GetResponse();
            StreamReader strm = new StreamReader(myHttpWebresponse.GetResponseStream());
            HtmlText = strm.ReadToEnd();
            strm.Close();
            int len = HtmlText.Length;
            byte[] b = new byte[len];
            b = Encoding.UTF8.GetBytes(HtmlText);
            HtmlText = "";
            HtmlText = Encoding.UTF8.GetString(b);
            Show_Data.Text = HtmlText;    
           // DataContractJsonSerializer Interrp = new DataContractJsonSerializer(typeof(List<Сurrency>));
           // List<Сurrency> cur = (List<Сurrency>)Interrp.ReadObject(HtmlText); 
           
        }
    }

    public class Сurrency
    {
        public int Cur_ID { get; set; }
        public int Cur_ParentID { get; set; }
        public string Cur_Code { get; set; }
        public string Cur_Abbreviation { get; set; }
        public string Cur_Name { get; set; }
        public string Cur_Name_Bel { get; set; }
        public string Cur_Name_Eng { get; set; }
        public string Cur_QuotName { get; set; }
        public string Cur_QuotName_Bel { get; set; }
        public string Cur_QuotName_Eng { get; set; }
        public string Cur_NameMulti { get; set; }
        public string Cur_Name_BelMulti { get; set; }
        public string Cur_Name_EngMulti { get; set; }
        public int Cur_Scale { get; set; }
        public int Cur_Periodicity { get; set; }
        public DateTime Cur_DateStart { get; set; }
        public DateTime Cur_DateEnd { get; set; }
    }

}
