using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Net.Mail;
using System.Threading;

namespace WcfService1
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string URL = "http://www.nbrb.by/API/ExRates/Currencies/231";

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

        
        public string Get_Data_Web()
        {
            return Asyng_Get_API(URL).Result;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
