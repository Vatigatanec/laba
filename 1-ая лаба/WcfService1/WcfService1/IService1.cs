using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        MyСurrency Get_Data_Web();

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Добавьте здесь операции служб
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


    // Используйте контракт данных, как показано в примере ниже, чтобы добавить составные типы к операциям служб.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
