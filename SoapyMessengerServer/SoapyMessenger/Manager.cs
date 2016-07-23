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
            users[from].addMessage(msg, from, to);
            users[to].addMessage(msg, from, to);
            return true;
        }

        public string checkMessages(string from, string to, out string error)
        {
            error = null;
            if (!users.ContainsKey(from))
            {
                error = "Invalid User.";
                return null;
            }
            else {
                string s = String.Empty;
                foreach (Message m in users[from].getMessage(to))
                {
                    s += (" [" + m.from + "]" + m.messageTime.ToLongTimeString() + '\t' + m.message + Environment.NewLine).PadLeft(0);
                } return s;
            }

        }

        public List<string> getContacts(string user)
        {
            List<string> s = users.Keys.ToList();
            s.Remove(user);
            return s;
        }
    }
}
