using SoapyMessengerClient.SoapyMessenger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoapyMessengerClient
{
    public partial class Form1 : Form
    {
        private ManagerClient client;
        private string user;
        Timer t = new Timer();

        public Form1()
        {
            InitializeComponent();
            client = new ManagerClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string error;
            client.login(usernameBox.Text, passwordBox.Text, IPAddress.Parse("127.0.0.1"), out error);
            if (error != null)
            {
                errorMessage.Text = error;
                t.Interval = 3000;
                t.Tick += TimerOnTick;
                t.Enabled = true;
            } else
            {
                MessageBoard msgBoard = new MessageBoard(usernameBox.Text, client);
                msgBoard.Show();
            }
            usernameBox.Text = String.Empty;
            passwordBox.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string error;
            client.signUp(usernameBox.Text, passwordBox.Text, out error);
            usernameBox.Text = String.Empty;
            passwordBox.Text = String.Empty;
            if (error == null) errorMessage.Text = "Signed Up!";
            else errorMessage.Text = error;

            t.Interval = 3000;
            t.Tick += TimerOnTick;
            t.Enabled = true;
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            errorMessage.Text = "";
            t.Enabled = false;
        }
    }
}
