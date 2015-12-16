using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using System.Xml.Linq;

namespace WcfServiceLibrary2
{
    public class AddressBook : IAddressBook
    {
        public bool AddContact(Contact con)
        {
            var file = ConfigurationManager.AppSettings["ContactBook"];
            string s = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var doc =XDocument.Load(s + file);
            var elements = doc.Descendants("Contact").Where(x => x.Element("FIO").Value == con.FIO).Where(x => x.Element("Phone").Value == con.Phone);
            if (elements.Count() == 0)
            {
                doc.Root.Add(new XElement("Contact", new XElement("FIO", con.FIO), new XElement("Phone", con.Phone)));
                doc.Save(s + file);
                return true;
            }
            return false;
        }

        public Contact[] GetContacts()
        {
            var file = ConfigurationManager.AppSettings["ContactBook"];
            string s = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var doc = XDocument.Load(s + file);
            var elements = doc.Descendants("Contact");
            return ConvertToArray(elements);
        }

        public Contact[] GetContactsByPhone(string phone)
        {
            phone = Contact.IsPhone(phone);
            return GetContactByElement("Phone", phone);
        }

        public Contact[] GetContactsByName(string name)
        {
            name = Contact.IsFIO(name);
            return GetContactByElement("FIO", name);
        }

        public bool ChangePhone(Contact contact, string newPhone)
        {
            var file = ConfigurationManager.AppSettings["ContactBook"];
            string s = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var doc = XDocument.Load(s + file);
            var elements = doc.Descendants("Contact").Where(x => x.Element("FIO").Value == contact.FIO).Where(x => x.Element("Phone").Value == contact.Phone);
            if (elements.Count() != 0)
            {
                doc.Root.Elements().Where(x => (x.Element("FIO").Value == contact.FIO) && (x.Element("Phone").Value == contact.Phone)).ElementAt(0).Element("Phone").SetValue(newPhone);
                doc.Save(s + file);
                return true;
            }
            return false;
        }

        public bool ChangePhone(int index, string newPhone)
        {
            var file = ConfigurationManager.AppSettings["ContactBook"];
            string s = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var doc = XDocument.Load(s + file);
            if ((index < 0) || (index >= doc.Root.Elements().Count()))
                return false;
            doc.Root.Elements().ElementAt(index).Element("Phone").SetValue(newPhone);
            doc.Save(s + file);
            return true;
        }

        public bool DeleteContact(Contact contact)
        {
            var file = ConfigurationManager.AppSettings["ContactBook"];
            string s = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var doc = XDocument.Load(s + file);
            var elements = doc.Descendants("Contact").Where(x => x.Element("FIO").Value == contact.FIO).Where(x => x.Element("Phone").Value == contact.Phone);
            if (elements.Count() != 0)
            {
                doc.Root.Elements().Where(x => (x.Element("FIO").Value == contact.FIO) && (x.Element("Phone").Value == contact.Phone)).ElementAt(0).Remove();
                doc.Save(s + file);
                return true;
            }
            return false;
        }

        public bool DeleteContact(int index)
        {
            var file = ConfigurationManager.AppSettings["ContactBook"];
            string s = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var doc = XDocument.Load(s + file);
            if ((index < 0) || (index >= doc.Root.Elements().Count()))
                return false;
            doc.Root.Elements().ElementAt(index).Remove();
            doc.Save(s + file);
            return true;
        }

        public Contact CreateContract(string FIO, string phone)
        {
            return new Contact(FIO, phone);
        }

        private Contact[] ConvertToArray(IEnumerable<XElement> elements)
        {
            int col = elements.Count();
            Contact[] result = new Contact[col];
            for (int i = 0; i < col; i++)
            {
                Contact cont = new Contact();
                cont.FIO = elements.ElementAt(i).Element("FIO").Value;
                cont.Phone = elements.ElementAt(i).Element("Phone").Value;
                result[i] = cont;
            }
            return result;
        }

        private Contact[] GetContactByElement(string elementName, string elementValue)
        {
            if (elementValue != string.Empty)
            {
                var file = ConfigurationManager.AppSettings["ContactBook"];
                string s = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                var doc = XDocument.Load(s + file);
                var elements = doc.Descendants("Contact").Where(x => x.Element(elementName).Value == elementValue);
                return ConvertToArray(elements);
            }
            else
                return new Contact[0];
        }
    }
}
