using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApplication1.ServiceReference1;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            AddressBookClient client = new AddressBookClient();
            Contact[] contacts = client.GetContacts();
            foreach (Contact cont in contacts)
            {
                string s = cont.FIO + " - " + cont.Phone;
                listBox.Items.Add(s);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            AddressBookClient client = new AddressBookClient();
            Contact[] contacts = client.GetContactsByName(textBox.Text);
            foreach (Contact cont in contacts)
            {
                string s = cont.FIO + " - " + cont.Phone;
                listBox.Items.Add(s);
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            AddressBookClient client = new AddressBookClient();
            Contact[] contacts = client.GetContactsByPhone(textBox1.Text);
            foreach (Contact cont in contacts)
            {
                string s = cont.FIO + " - " + cont.Phone;
                listBox.Items.Add(s);
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            AddressBookClient client = new AddressBookClient();
            bool Added = client.AddContact(client.CreateContract(textBox2.Text, textBox3.Text));
            if (!Added)
                MessageBox.Show("Контакт не был добавлен");
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            string newNumber = textBox5.Text;
            AddressBookClient client = new AddressBookClient();
            bool change = false;
            if (checkBox.IsChecked == true)
                change = client.ChangePhoneByIndex(int.Parse(textBox7.Text), newNumber);
            else
                change = client.ChangPhoneByContact(client.CreateContract(textBox4.Text, textBox6.Text), newNumber);
            if (!change)
                MessageBox.Show("Номер не был изменен");
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            AddressBookClient client = new AddressBookClient();
            bool delete = false;
            if (checkBox1.IsChecked == true)
                delete = client.DeleteByIndex(int.Parse(textBox10.Text));
            else
                delete = client.DeleteByContact(client.CreateContract(textBox9.Text, textBox8.Text));
            if (!delete)
                MessageBox.Show("Запись не была Удалены!");
        }
    }
}
