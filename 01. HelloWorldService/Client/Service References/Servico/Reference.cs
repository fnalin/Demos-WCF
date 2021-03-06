﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.Servico {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Name", Namespace="http://schemas.datacontract.org/2004/07/HelloWorldService")]
    [System.SerializableAttribute()]
    public partial class Name : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string First {
            get {
                return this.FirstField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstField, value) != true)) {
                    this.FirstField = value;
                    this.RaisePropertyChanged("First");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Last {
            get {
                return this.LastField;
            }
            set {
                if ((object.ReferenceEquals(this.LastField, value) != true)) {
                    this.LastField = value;
                    this.RaisePropertyChanged("Last");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Servico.IHelloWorld")]
    public interface IHelloWorld {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorld/SayHello", ReplyAction="http://tempuri.org/IHelloWorld/SayHelloResponse")]
        string SayHello(Client.Servico.Name person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorld/SayHello", ReplyAction="http://tempuri.org/IHelloWorld/SayHelloResponse")]
        System.Threading.Tasks.Task<string> SayHelloAsync(Client.Servico.Name person);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloWorldChannel : Client.Servico.IHelloWorld, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWorldClient : System.ServiceModel.ClientBase<Client.Servico.IHelloWorld>, Client.Servico.IHelloWorld {
        
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
        
        public string SayHello(Client.Servico.Name person) {
            return base.Channel.SayHello(person);
        }
        
        public System.Threading.Tasks.Task<string> SayHelloAsync(Client.Servico.Name person) {
            return base.Channel.SayHelloAsync(person);
        }
    }
}
