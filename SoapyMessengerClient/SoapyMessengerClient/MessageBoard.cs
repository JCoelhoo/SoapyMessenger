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
    public partial class MessageBoard : Form
    {
        public string user ="";
        public ManagerClient client;
        private Timer t = new Timer();
        public MessageBoard(string _user, ManagerClient c)
        {
            InitializeComponent();
            client = c;
            user = _user;
            foreach(var friend in client.getContacts(user))
                listBox1.Items.Add(friend);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Message_Click(object sender, EventArgs e)
        {
            (new Conversation(user, listBox1.SelectedItem.ToString(), client)).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (client.getContacts(user).Contains(textBox1.Text))
            {
                (new Conversation(user, textBox1.Text, client)).Show();
                textBox1.Text = String.Empty;
            }
            else
            {
                error.Text = "User does not exist";
                t.Interval = 3000;
                t.Tick += TimerOnTick;
                t.Enabled = true;
            }
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            error.Text = "";
            t.Enabled = false;
        }
    }
}
