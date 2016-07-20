using SoapyMessenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SoapyServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Manager : IManager
    {
        public string name { get; set; }
        public string password { get; set; }
        private Dictionary<string, User> users = new Dictionary<string, User>() { { "a", new User("a", "a")}, { "b", new User("b", "b") } };
        private Dictionary<string, IPAddress> loggedUsers = new Dictionary<string, IPAddress>();
        private Dictionary<string, List<Message>> queuedMessages = new Dictionary<string, List<Message>>();
        private Dictionary<string, List<string>> friends = new Dictionary<string, List<string>>();

        public Manager()
        {
            //name = _name;
            //password = _password;

        }

        public bool login(string name, string password, out string error, IPAddress ip)
        {
            error = null;
            if (users.ContainsKey(name))
            {
                if (password == users[name].password)
                    return true;
                else
                {
                    error = "Invalid password";
                    return false;
                }
            }
            else
            {
                error = "Invalid username.";
                return false;
            }
        }

        public bool signUp(string name, string password, out string error)
        {
            error = null;
            if (users.ContainsKey(name))
            {
                error = "Username already exists";
                return false;
            }
            else
            {
                users.Add(name, new User(name, password));
                return true;
            }
        }

        public bool sendMessage(out string error, string msg, string from, string to)
        {
            error = null;
            if (!users.ContainsKey(to))
            {
                error = "Invalid User.";
                return false;
            }
            users[from].addMessage(msg, to);
            return true;
        }

        public string checkMessages(string from, string to, out string error, out DateTime date, out string msg)
        {
            error = null;
            date = DateTime.Now;
            msg = null;
            if (!users.ContainsKey(from))
            {
                error = "Invalid User.";
                return null;
            }
            //if (queuedMessages[from].Count == 0)
            //{
            //    error = "No messages";
            //    return false;
            //}
            else {
                string s = String.Empty;
                foreach (Message m in users[from].getMessage(to))
                {
                    if (m.receiver.Equals(to))
                        s += "[" + from + "] " + m.messageTime.ToLongTimeString() + '\t' + m.message + Environment.NewLine;
                    else
                        s += ("[" + to + "]" + m.messageTime.ToLongTimeString() + '\t' + m.message + Environment.NewLine).PadRight(0);
                } return s;
            }

        }

        public List<string> getContacts(string user)
        {
            return users[user].getFriends();
        }
    }
}
