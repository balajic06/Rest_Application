﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Verification_Service", ReplyAction="http://tempuri.org/IService1/Verification_ServiceResponse")]
        string Verification_Service(string xmlpath, string xsdpath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Verification_Service", ReplyAction="http://tempuri.org/IService1/Verification_ServiceResponse")]
        System.Threading.Tasks.Task<string> Verification_ServiceAsync(string xmlpath, string xsdpath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Transformation_Service", ReplyAction="http://tempuri.org/IService1/Transformation_ServiceResponse")]
        string Transformation_Service(string xmlpath, string xslpath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Transformation_Service", ReplyAction="http://tempuri.org/IService1/Transformation_ServiceResponse")]
        System.Threading.Tasks.Task<string> Transformation_ServiceAsync(string xmlpath, string xslpath);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplication2.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplication2.ServiceReference1.IService1>, WebApplication2.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Verification_Service(string xmlpath, string xsdpath) {
            return base.Channel.Verification_Service(xmlpath, xsdpath);
        }
        
        public System.Threading.Tasks.Task<string> Verification_ServiceAsync(string xmlpath, string xsdpath) {
            return base.Channel.Verification_ServiceAsync(xmlpath, xsdpath);
        }
        
        public string Transformation_Service(string xmlpath, string xslpath) {
            return base.Channel.Transformation_Service(xmlpath, xslpath);
        }
        
        public System.Threading.Tasks.Task<string> Transformation_ServiceAsync(string xmlpath, string xslpath) {
            return base.Channel.Transformation_ServiceAsync(xmlpath, xslpath);
        }
    }
}