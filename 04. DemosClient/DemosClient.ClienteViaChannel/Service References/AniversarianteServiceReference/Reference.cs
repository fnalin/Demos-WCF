﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemosClient.ClienteViaChannel.AniversarianteServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Aniversariante", Namespace="http://schemas.datacontract.org/2004/07/DemosClient.Service")]
    [System.SerializableAttribute()]
    public partial class Aniversariante : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
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
        public System.DateTime Data {
            get {
                return this.DataField;
            }
            set {
                if ((this.DataField.Equals(value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AniversarianteServiceReference.IAniversarianteService")]
    public interface IAniversarianteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAniversarianteService/AddAniversariante", ReplyAction="http://tempuri.org/IAniversarianteService/AddAniversarianteResponse")]
        void AddAniversariante(DemosClient.ClienteViaChannel.AniversarianteServiceReference.Aniversariante aniversariante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAniversarianteService/AddAniversariante", ReplyAction="http://tempuri.org/IAniversarianteService/AddAniversarianteResponse")]
        System.Threading.Tasks.Task AddAniversarianteAsync(DemosClient.ClienteViaChannel.AniversarianteServiceReference.Aniversariante aniversariante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAniversarianteService/GetAniversariantes", ReplyAction="http://tempuri.org/IAniversarianteService/GetAniversariantesResponse")]
        DemosClient.ClienteViaChannel.AniversarianteServiceReference.Aniversariante[] GetAniversariantes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAniversarianteService/GetAniversariantes", ReplyAction="http://tempuri.org/IAniversarianteService/GetAniversariantesResponse")]
        System.Threading.Tasks.Task<DemosClient.ClienteViaChannel.AniversarianteServiceReference.Aniversariante[]> GetAniversariantesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAniversarianteServiceChannel : DemosClient.ClienteViaChannel.AniversarianteServiceReference.IAniversarianteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AniversarianteServiceClient : System.ServiceModel.ClientBase<DemosClient.ClienteViaChannel.AniversarianteServiceReference.IAniversarianteService>, DemosClient.ClienteViaChannel.AniversarianteServiceReference.IAniversarianteService {
        
        public AniversarianteServiceClient() {
        }
        
        public AniversarianteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AniversarianteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AniversarianteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AniversarianteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddAniversariante(DemosClient.ClienteViaChannel.AniversarianteServiceReference.Aniversariante aniversariante) {
            base.Channel.AddAniversariante(aniversariante);
        }
        
        public System.Threading.Tasks.Task AddAniversarianteAsync(DemosClient.ClienteViaChannel.AniversarianteServiceReference.Aniversariante aniversariante) {
            return base.Channel.AddAniversarianteAsync(aniversariante);
        }
        
        public DemosClient.ClienteViaChannel.AniversarianteServiceReference.Aniversariante[] GetAniversariantes() {
            return base.Channel.GetAniversariantes();
        }
        
        public System.Threading.Tasks.Task<DemosClient.ClienteViaChannel.AniversarianteServiceReference.Aniversariante[]> GetAniversariantesAsync() {
            return base.Channel.GetAniversariantesAsync();
        }
    }
}
