﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Digst.OioIdws.LibBas.Test.HelloWorldProxy {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HelloWorldProxy.IHelloWorld")]
    public interface IHelloWorld {
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.None, Action="http://tempuri.org/IHelloWorld/HelloNone", ReplyAction="http://tempuri.org/IHelloWorld/HelloNoneResponse")]
        string HelloNone(string name);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.None, Action="http://tempuri.org/IHelloWorld/HelloNone", ReplyAction="http://tempuri.org/IHelloWorld/HelloNoneResponse")]
        System.Threading.Tasks.Task<string> HelloNoneAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.None, Action="http://tempuri.org/IHelloWorld/HelloNoneError", ReplyAction="http://tempuri.org/IHelloWorld/HelloNoneErrorResponse")]
        string HelloNoneError(string name);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.None, Action="http://tempuri.org/IHelloWorld/HelloNoneError", ReplyAction="http://tempuri.org/IHelloWorld/HelloNoneErrorResponse")]
        System.Threading.Tasks.Task<string> HelloNoneErrorAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.Sign, Action="http://tempuri.org/IHelloWorld/HelloSign", ReplyAction="http://tempuri.org/IHelloWorld/HelloSignResponse")]
        string HelloSign(string name);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.Sign, Action="http://tempuri.org/IHelloWorld/HelloSign", ReplyAction="http://tempuri.org/IHelloWorld/HelloSignResponse")]
        System.Threading.Tasks.Task<string> HelloSignAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.Sign, Action="http://tempuri.org/IHelloWorld/HelloSignError", ReplyAction="http://tempuri.org/IHelloWorld/HelloSignErrorResponse")]
        string HelloSignError(string name);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.Sign, Action="http://tempuri.org/IHelloWorld/HelloSignError", ReplyAction="http://tempuri.org/IHelloWorld/HelloSignErrorResponse")]
        System.Threading.Tasks.Task<string> HelloSignErrorAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.Sign, Action="http://tempuri.org/IHelloWorld/HelloSignErrorNotEncrypted", ReplyAction="http://tempuri.org/IHelloWorld/HelloSignErrorNotEncryptedResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://tempuri.org/IHelloWorld/HelloSignErrorNotEncryptedStringFault", ProtectionLevel=System.Net.Security.ProtectionLevel.Sign, Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        string HelloSignErrorNotEncrypted(string name);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.Sign, Action="http://tempuri.org/IHelloWorld/HelloSignErrorNotEncrypted", ReplyAction="http://tempuri.org/IHelloWorld/HelloSignErrorNotEncryptedResponse")]
        System.Threading.Tasks.Task<string> HelloSignErrorNotEncryptedAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/IHelloWorld/HelloEncryptAndSign", ReplyAction="http://tempuri.org/IHelloWorld/HelloEncryptAndSignResponse")]
        string HelloEncryptAndSign(string name);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/IHelloWorld/HelloEncryptAndSign", ReplyAction="http://tempuri.org/IHelloWorld/HelloEncryptAndSignResponse")]
        System.Threading.Tasks.Task<string> HelloEncryptAndSignAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/IHelloWorld/HelloEncryptAndSignError", ReplyAction="http://tempuri.org/IHelloWorld/HelloEncryptAndSignErrorResponse")]
        string HelloEncryptAndSignError(string name);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/IHelloWorld/HelloEncryptAndSignError", ReplyAction="http://tempuri.org/IHelloWorld/HelloEncryptAndSignErrorResponse")]
        System.Threading.Tasks.Task<string> HelloEncryptAndSignErrorAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloWorldChannel : Digst.OioIdws.LibBas.Test.HelloWorldProxy.IHelloWorld, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWorldClient : System.ServiceModel.ClientBase<Digst.OioIdws.LibBas.Test.HelloWorldProxy.IHelloWorld>, Digst.OioIdws.LibBas.Test.HelloWorldProxy.IHelloWorld {
        
        public HelloWorldClient() {
        }
        
        public HelloWorldClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloWorldClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloNone(string name) {
            return base.Channel.HelloNone(name);
        }
        
        public System.Threading.Tasks.Task<string> HelloNoneAsync(string name) {
            return base.Channel.HelloNoneAsync(name);
        }
        
        public string HelloNoneError(string name) {
            return base.Channel.HelloNoneError(name);
        }
        
        public System.Threading.Tasks.Task<string> HelloNoneErrorAsync(string name) {
            return base.Channel.HelloNoneErrorAsync(name);
        }
        
        public string HelloSign(string name) {
            return base.Channel.HelloSign(name);
        }
        
        public System.Threading.Tasks.Task<string> HelloSignAsync(string name) {
            return base.Channel.HelloSignAsync(name);
        }
        
        public string HelloSignError(string name) {
            return base.Channel.HelloSignError(name);
        }
        
        public System.Threading.Tasks.Task<string> HelloSignErrorAsync(string name) {
            return base.Channel.HelloSignErrorAsync(name);
        }
        
        public string HelloSignErrorNotEncrypted(string name) {
            return base.Channel.HelloSignErrorNotEncrypted(name);
        }
        
        public System.Threading.Tasks.Task<string> HelloSignErrorNotEncryptedAsync(string name) {
            return base.Channel.HelloSignErrorNotEncryptedAsync(name);
        }
        
        public string HelloEncryptAndSign(string name) {
            return base.Channel.HelloEncryptAndSign(name);
        }
        
        public System.Threading.Tasks.Task<string> HelloEncryptAndSignAsync(string name) {
            return base.Channel.HelloEncryptAndSignAsync(name);
        }
        
        public string HelloEncryptAndSignError(string name) {
            return base.Channel.HelloEncryptAndSignError(name);
        }
        
        public System.Threading.Tasks.Task<string> HelloEncryptAndSignErrorAsync(string name) {
            return base.Channel.HelloEncryptAndSignErrorAsync(name);
        }
    }
}
