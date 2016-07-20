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
    }
}
