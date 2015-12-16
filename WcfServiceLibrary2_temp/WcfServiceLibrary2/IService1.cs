using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary2
{
    [ServiceContract]
    public interface IAddressBook
    {
        [OperationContract]
        Contact CreateContract(string FIO, string phone);

        [OperationContract]
        bool AddContact(Contact cont);

        [OperationContract]
        Contact[] GetContacts();

        [OperationContract]
        Contact[] GetContactsByPhone(string phone);

        [OperationContract]
        Contact[] GetContactsByName(string name);
        
        [OperationContract(Name = "ChangPhoneByContact")]
        bool ChangePhone(Contact contact, string newPhone);

        [OperationContract(Name = "ChangePhoneByIndex")]
        bool ChangePhone(int index, string newPhone);

        [OperationContract(Name = "DeleteByContact")]
        bool DeleteContact(Contact contact);
        
        [OperationContract(Name = "DeleteByIndex")]
        bool DeleteContact(int index);
    }

    [DataContract]
    public class Contact
    {
        public Contact(string fio, string phone)
        {
            FIO = fio;
            Phone = phone;
        }

        public Contact() { }

        private string phone;
        private string fio;

        [DataMember]
        public string FIO
        {
            get { return fio; }
            set
            {
                value = Contact.IsFIO(value);
                if (value != string.Empty)
                    fio = value;
                else
                    throw new FormatException("Wrong name");
            }
        }

        [DataMember]
        public string Phone
        {
            get { return phone; }
            set
            {
                value = IsPhone(value);
                if (value != string.Empty)
                    phone = value;
                else
                    throw new FormatException("Wrong phone");
            }
        }

        public static string IsPhone(string phoneNum)
        {
            phoneNum = phoneNum.Trim().Replace(" ", "");
            if (phoneNum.Length == 11)
            {
                if (phoneNum[0] != '8')
                    return string.Empty;
            }
            else if (phoneNum.Length == 12)
            {
                if (phoneNum[0] != '+' || phoneNum[1] != '7')
                    return string.Empty;
            }
            else
                return string.Empty;
            for (int i = 1; i < phoneNum.Length; i++)
                if (!Char.IsDigit(phoneNum[i]))
                    return string.Empty;
            return phoneNum;
        }

        public static string IsFIO(string name)
        {
            name = name.Trim();
            while (name.Contains("  "))
                name = name.Replace("  ", " ");
            foreach (char ch in name)
                if ((!char.IsLetter(ch)) && (ch != ' '))
                    return string.Empty;
            if (name.Split(' ').Length == 3)
            {

                StringBuilder sb = new StringBuilder(name);
                sb[0] = char.ToUpper(sb[0]);
                int i = 1;
                for (int j = 1; j < sb.Length - 1; j++)
                {
                    if (sb[j] == ' ')
                    {
                        sb[j + 1] = char.ToUpper(sb[j + 1]);
                        i++;
                    }
                    if (i == 3)
                        return sb.ToString();
                }
            }
            return string.Empty;
        }
    }
}
