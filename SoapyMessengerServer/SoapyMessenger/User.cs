using SoapyServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapyMessenger
{
    class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public Dictionary<string, List<Message>> conversations = new Dictionary<string, List<Message>>();// { { "b", new List<Message>() { new Message(DateTime.Now, "b", "..") } }, { "a", new List<Message>() { new Message(DateTime.Now, "a", "..") } } };

        public User(string _username, string _password)
        {
            username = _username;
            password = _password;
        }

        public List<string> getFriends()
        {
            return conversations.Keys.ToList();
        }

        public void addMessage(string message, string from, string to)
        {
            string target;
            if (!from.Equals(username)) target = from;
            else target = to;
            if (!conversations.ContainsKey(target))
            {
                 conversations.Add(target, new List<Message> { new Message(DateTime.Now, from, to, message) });
            }
            else {
                List<Message> m = conversations[target];
                m.Add(new Message(DateTime.Now, from, to, message));
                conversations[to] = m;
            }
        }

        public List<Message> getMessage(string to) {
            return conversations.ContainsKey(to) ? conversations[to] : new List<Message>();
        }


    }
}
