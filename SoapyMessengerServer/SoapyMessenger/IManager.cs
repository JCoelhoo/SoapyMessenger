using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SoapyServer
{
    [ServiceContract]
    public interface IManager
    {
        [OperationContract]
        bool login(string name, string password, out string error, IPAddress ip);

        [OperationContract]
        bool signUp(string name, string password, out string error);

        [OperationContract]
        bool sendMessage(out string error, string msg, string from, string to);

        [OperationContract]
        string checkMessages(string from, string to, out string error, out DateTime date, out string msg);

        [OperationContract]
        List<string> getContacts(string user);
    }
}
