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
        public string receiver { get; set; }
        public string message { get; set; }
        public Message(DateTime msgTime, string _receiver, string msg)
        {
            messageTime = msgTime;
            receiver = _receiver;
            message = msg;
        }
    }
}