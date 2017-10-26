﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Net.Mail;
using System.Threading;

namespace laba1
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }


        private bool Send_Message(string data)
        {
            bool result = false;

            /*MailAddress from = new MailAddress("ilyavatigatanec@gmail.com", "Илья");
            MailAddress to = new MailAddress("sis37373@gmail.com");
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Результат";
            m.Body = data;
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.ru", 587);
            smtp.Credentials = new NetworkCredential("ilyavatigatanec@gmail.com", "XTHYSQjnhzl7");
            smtp.EnableSsl = true;
            smtp.Send(m);*/

            var fromAddress = new MailAddress("ilyavatigatanec@gmail.com", "Ilia");
            var toAddress = new MailAddress("sis37373@gmail.com", "Ilia");
            const string fromPassword = "XTHYSQjnhzl7";
            const string subject = "Json";
            string body = data;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }

            return result;
        }

        private async Task<string> Get_API(string url)
        {
            string result;
            HttpWebRequest myHttwebrequest = (HttpWebRequest)HttpWebRequest.Create(url);
            HttpWebResponse myHttpWebresponse = (HttpWebResponse)myHttwebrequest.GetResponse();
            StreamReader strm = new StreamReader(myHttpWebresponse.GetResponseStream());
            result = strm.ReadToEnd();
            strm.Close();
            int len = result.Length;
            byte[] b = new byte[len];
            b = Encoding.UTF8.GetBytes(result);
            result = "";
            result = Encoding.UTF8.GetString(b);
            return result;
        }

        private async Task<string> Asyng_Get_API(string url)
        {
            var res = await Get_API(url);
            Thread.Sleep(1000);
            return res;
        }

        private void Deser_Data(object data,ref MyСurrency currency)
        {
            currency = JsonConvert.DeserializeObject<MyСurrency>((string)data);
            //return currency;
        }

        private void Output_Data(object data, MyСurrency currency)
        {
            //MyСurrency currency = JsonConvert.DeserializeObject<MyСurrency>((string)obj.data);
            Show_Data.Text  = (string)data;
            Output.Text =
                "Буквенный код: " + currency.Cur_Abbreviation + Environment.NewLine +
                "Цифровой код: " + currency.Cur_Code + Environment.NewLine +
                "Дата исключения валюты из перечня валют: " + currency.Cur_DateEnd + Environment.NewLine +
                "Дата включения валюты в перечень валют: " + currency.Cur_DateStart + Environment.NewLine +
                "Внутренний код: " + currency.Cur_ID + Environment.NewLine +
                "Наименование валюты на русском языке: " + currency.Cur_Name + Environment.NewLine +
                "Наименование валюты на русском языке во множественном числе: " + currency.Cur_NameMulti + Environment.NewLine +
                "Наименование на белорусском языке: " + currency.Cur_Name_Bel + Environment.NewLine +
                "Наименование валюты на белорусском языке во множественном числе: " + currency.Cur_Name_BelMulti + Environment.NewLine +
                "Наименование на английском языке: " + currency.Cur_Name_Eng + Environment.NewLine +
                "Наименование на английском языке во множественном числе: " + currency.Cur_Name_EngMulti + Environment.NewLine +
                "Этот код используется для связи, при изменениях наименования: " + currency.Cur_ParentID + Environment.NewLine +
                "Периодичность установления курса: " + currency.Cur_Periodicity + Environment.NewLine +
                "Наименование валюты на русском языке, содержащее количество единиц: " + currency.Cur_QuotName + Environment.NewLine +
                "Наименование на белорусском языке, содержащее количество единиц: " + currency.Cur_QuotName_Bel + Environment.NewLine +
                "Наименование на английском языке, содержащее количество единиц: " + currency.Cur_QuotName_Eng + Environment.NewLine +
                "Количество единиц иностранной валюты: " + currency.Cur_Scale + Environment.NewLine;
        }

        private void Get_Data_Click(object sender, EventArgs e)
        {
            string API = Asyng_Get_API(URL.Text).Result;
            MyСurrency currency = null;
            ThreadPool.QueueUserWorkItem(_ => Deser_Data(API,ref currency));
            Thread.Sleep(1000);
            Output_Data(API, currency);
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Send_Message(Output.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string API = Get_API(URL.Text).Result;
            MyСurrency currency = null;
            ThreadPool.QueueUserWorkItem(_ => Deser_Data(API, ref currency));
            Thread.Sleep(1000);
            Output_Data(API, currency);
            time.Text = DateTime.Now.ToString();
        }
    }

    public class MyСurrency
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
