using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SoapyServer
{
    public class Message 
    {
        public DateTime messageTime { set; get; }
        public string to { get; set; }
        public string from { get; set; }
        public string message { get; set; }
        public Message(DateTime msgTime, string _from, string _receiver, string msg)
        {
            from = _from;
            messageTime = msgTime;
            to = _receiver;
            message = msg;
        }
    }
}