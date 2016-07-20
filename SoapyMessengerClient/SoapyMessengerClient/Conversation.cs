using SoapyMessengerClient.SoapyMessenger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoapyMessengerClient
{
    public partial class Conversation : Form
    {
        public string user;
        public string friend;
        public ManagerClient client;
        public Conversation(string _user, string _friend, ManagerClient c)
        {
            InitializeComponent();
            user = _user;
            friend = _friend;
            client = c;
            check();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string error;
            client.sendMessage(textBox1.Text, user, friend, out error);
            check();
            textBox1.Text = String.Empty;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            check();
        }
        
        private void check()
        {
            string message;
            DateTime date;
            string error;
            textBox2.Text = client.checkMessages(user, friend, out error, out date, out message);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
