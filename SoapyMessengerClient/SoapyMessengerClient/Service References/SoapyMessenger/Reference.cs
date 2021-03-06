﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoapyMessengerClient.SoapyMessenger {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SoapyMessenger.IManager")]
    public interface IManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManager/login", ReplyAction="http://tempuri.org/IManager/loginResponse")]
        SoapyMessengerClient.SoapyMessenger.loginResponse login(SoapyMessengerClient.SoapyMessenger.loginRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManager/login", ReplyAction="http://tempuri.org/IManager/loginResponse")]
        System.Threading.Tasks.Task<SoapyMessengerClient.SoapyMessenger.loginResponse> loginAsync(SoapyMessengerClient.SoapyMessenger.loginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManager/signUp", ReplyAction="http://tempuri.org/IManager/signUpResponse")]
        SoapyMessengerClient.SoapyMessenger.signUpResponse signUp(SoapyMessengerClient.SoapyMessenger.signUpRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManager/signUp", ReplyAction="http://tempuri.org/IManager/signUpResponse")]
        System.Threading.Tasks.Task<SoapyMessengerClient.SoapyMessenger.signUpResponse> signUpAsync(SoapyMessengerClient.SoapyMessenger.signUpRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManager/sendMessage", ReplyAction="http://tempuri.org/IManager/sendMessageResponse")]
        SoapyMessengerClient.SoapyMessenger.sendMessageResponse sendMessage(SoapyMessengerClient.SoapyMessenger.sendMessageRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManager/sendMessage", ReplyAction="http://tempuri.org/IManager/sendMessageResponse")]
        System.Threading.Tasks.Task<SoapyMessengerClient.SoapyMessenger.sendMessageResponse> sendMessageAsync(SoapyMessengerClient.SoapyMessenger.sendMessageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManager/checkMessages", ReplyAction="http://tempuri.org/IManager/checkMessagesResponse")]
        SoapyMessengerClient.SoapyMessenger.checkMessagesResponse checkMessages(SoapyMessengerClient.SoapyMessenger.checkMessagesRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManager/checkMessages", ReplyAction="http://tempuri.org/IManager/checkMessagesResponse")]
        System.Threading.Tasks.Task<SoapyMessengerClient.SoapyMessenger.checkMessagesResponse> checkMessagesAsync(SoapyMessengerClient.SoapyMessenger.checkMessagesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManager/getContacts", ReplyAction="http://tempuri.org/IManager/getContactsResponse")]
        string[] getContacts(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManager/getContacts", ReplyAction="http://tempuri.org/IManager/getContactsResponse")]
        System.Threading.Tasks.Task<string[]> getContactsAsync(string user);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="login", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class loginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string password;
        
        public loginRequest() {
        }
        
        public loginRequest(string name, string password) {
            this.name = name;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="loginResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class loginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool loginResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string error;
        
        public loginResponse() {
        }
        
        public loginResponse(bool loginResult, string error) {
            this.loginResult = loginResult;
            this.error = error;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="signUp", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class signUpRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string password;
        
        public signUpRequest() {
        }
        
        public signUpRequest(string name, string password) {
            this.name = name;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="signUpResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class signUpResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool signUpResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string error;
        
        public signUpResponse() {
        }
        
        public signUpResponse(bool signUpResult, string error) {
            this.signUpResult = signUpResult;
            this.error = error;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendMessage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class sendMessageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string msg;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string from;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string to;
        
        public sendMessageRequest() {
        }
        
        public sendMessageRequest(string msg, string from, string to) {
            this.msg = msg;
            this.from = from;
            this.to = to;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendMessageResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class sendMessageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool sendMessageResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string error;
        
        public sendMessageResponse() {
        }
        
        public sendMessageResponse(bool sendMessageResult, string error) {
            this.sendMessageResult = sendMessageResult;
            this.error = error;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="checkMessages", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class checkMessagesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string from;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string to;
        
        public checkMessagesRequest() {
        }
        
        public checkMessagesRequest(string from, string to) {
            this.from = from;
            this.to = to;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="checkMessagesResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class checkMessagesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string checkMessagesResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string error;
        
        public checkMessagesResponse() {
        }
        
        public checkMessagesResponse(string checkMessagesResult, string error) {
            this.checkMessagesResult = checkMessagesResult;
            this.error = error;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IManagerChannel : SoapyMessengerClient.SoapyMessenger.IManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ManagerClient : System.ServiceModel.ClientBase<SoapyMessengerClient.SoapyMessenger.IManager>, SoapyMessengerClient.SoapyMessenger.IManager {
        
        public ManagerClient() {
        }
        
        public ManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SoapyMessengerClient.SoapyMessenger.loginResponse SoapyMessengerClient.SoapyMessenger.IManager.login(SoapyMessengerClient.SoapyMessenger.loginRequest request) {
            return base.Channel.login(request);
        }
        
        public bool login(string name, string password, out string error) {
            SoapyMessengerClient.SoapyMessenger.loginRequest inValue = new SoapyMessengerClient.SoapyMessenger.loginRequest();
            inValue.name = name;
            inValue.password = password;
            SoapyMessengerClient.SoapyMessenger.loginResponse retVal = ((SoapyMessengerClient.SoapyMessenger.IManager)(this)).login(inValue);
            error = retVal.error;
            return retVal.loginResult;
        }
        
        public System.Threading.Tasks.Task<SoapyMessengerClient.SoapyMessenger.loginResponse> loginAsync(SoapyMessengerClient.SoapyMessenger.loginRequest request) {
            return base.Channel.loginAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SoapyMessengerClient.SoapyMessenger.signUpResponse SoapyMessengerClient.SoapyMessenger.IManager.signUp(SoapyMessengerClient.SoapyMessenger.signUpRequest request) {
            return base.Channel.signUp(request);
        }
        
        public bool signUp(string name, string password, out string error) {
            SoapyMessengerClient.SoapyMessenger.signUpRequest inValue = new SoapyMessengerClient.SoapyMessenger.signUpRequest();
            inValue.name = name;
            inValue.password = password;
            SoapyMessengerClient.SoapyMessenger.signUpResponse retVal = ((SoapyMessengerClient.SoapyMessenger.IManager)(this)).signUp(inValue);
            error = retVal.error;
            return retVal.signUpResult;
        }
        
        public System.Threading.Tasks.Task<SoapyMessengerClient.SoapyMessenger.signUpResponse> signUpAsync(SoapyMessengerClient.SoapyMessenger.signUpRequest request) {
            return base.Channel.signUpAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SoapyMessengerClient.SoapyMessenger.sendMessageResponse SoapyMessengerClient.SoapyMessenger.IManager.sendMessage(SoapyMessengerClient.SoapyMessenger.sendMessageRequest request) {
            return base.Channel.sendMessage(request);
        }
        
        public bool sendMessage(string msg, string from, string to, out string error) {
            SoapyMessengerClient.SoapyMessenger.sendMessageRequest inValue = new SoapyMessengerClient.SoapyMessenger.sendMessageRequest();
            inValue.msg = msg;
            inValue.from = from;
            inValue.to = to;
            SoapyMessengerClient.SoapyMessenger.sendMessageResponse retVal = ((SoapyMessengerClient.SoapyMessenger.IManager)(this)).sendMessage(inValue);
            error = retVal.error;
            return retVal.sendMessageResult;
        }
        
        public System.Threading.Tasks.Task<SoapyMessengerClient.SoapyMessenger.sendMessageResponse> sendMessageAsync(SoapyMessengerClient.SoapyMessenger.sendMessageRequest request) {
            return base.Channel.sendMessageAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SoapyMessengerClient.SoapyMessenger.checkMessagesResponse SoapyMessengerClient.SoapyMessenger.IManager.checkMessages(SoapyMessengerClient.SoapyMessenger.checkMessagesRequest request) {
            return base.Channel.checkMessages(request);
        }
        
        public string checkMessages(string from, string to, out string error) {
            SoapyMessengerClient.SoapyMessenger.checkMessagesRequest inValue = new SoapyMessengerClient.SoapyMessenger.checkMessagesRequest();
            inValue.from = from;
            inValue.to = to;
            SoapyMessengerClient.SoapyMessenger.checkMessagesResponse retVal = ((SoapyMessengerClient.SoapyMessenger.IManager)(this)).checkMessages(inValue);
            error = retVal.error;
            return retVal.checkMessagesResult;
        }
        
        public System.Threading.Tasks.Task<SoapyMessengerClient.SoapyMessenger.checkMessagesResponse> checkMessagesAsync(SoapyMessengerClient.SoapyMessenger.checkMessagesRequest request) {
            return base.Channel.checkMessagesAsync(request);
        }
        
        public string[] getContacts(string user) {
            return base.Channel.getContacts(user);
        }
        
        public System.Threading.Tasks.Task<string[]> getContactsAsync(string user) {
            return base.Channel.getContactsAsync(user);
        }
    }
}
