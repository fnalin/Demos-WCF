﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoWCFSingleton.WebUI.AlunoService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AlunoModel", Namespace="http://schemas.datacontract.org/2004/07/DemoWCFSingleton.Service")]
    [System.SerializableAttribute()]
    public partial class AlunoModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CadastroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
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
        public System.DateTime Cadastro {
            get {
                return this.CadastroField;
            }
            set {
                if ((this.CadastroField.Equals(value) != true)) {
                    this.CadastroField = value;
                    this.RaisePropertyChanged("Cadastro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID {
            get {
                return this.IDField;
            }
            set {
                if ((object.ReferenceEquals(this.IDField, value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AlunoService.IAlunoService")]
    public interface IAlunoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlunoService/AdicionarAluno", ReplyAction="http://tempuri.org/IAlunoService/AdicionarAlunoResponse")]
        void AdicionarAluno(DemoWCFSingleton.WebUI.AlunoService.AlunoModel aluno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlunoService/AdicionarAluno", ReplyAction="http://tempuri.org/IAlunoService/AdicionarAlunoResponse")]
        System.Threading.Tasks.Task AdicionarAlunoAsync(DemoWCFSingleton.WebUI.AlunoService.AlunoModel aluno);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlunoService/ObterAlunos", ReplyAction="http://tempuri.org/IAlunoService/ObterAlunosResponse")]
        DemoWCFSingleton.WebUI.AlunoService.AlunoModel[] ObterAlunos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAlunoService/ObterAlunos", ReplyAction="http://tempuri.org/IAlunoService/ObterAlunosResponse")]
        System.Threading.Tasks.Task<DemoWCFSingleton.WebUI.AlunoService.AlunoModel[]> ObterAlunosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAlunoServiceChannel : DemoWCFSingleton.WebUI.AlunoService.IAlunoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AlunoServiceClient : System.ServiceModel.ClientBase<DemoWCFSingleton.WebUI.AlunoService.IAlunoService>, DemoWCFSingleton.WebUI.AlunoService.IAlunoService {
        
        public AlunoServiceClient() {
        }
        
        public AlunoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AlunoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AlunoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AlunoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AdicionarAluno(DemoWCFSingleton.WebUI.AlunoService.AlunoModel aluno) {
            base.Channel.AdicionarAluno(aluno);
        }
        
        public System.Threading.Tasks.Task AdicionarAlunoAsync(DemoWCFSingleton.WebUI.AlunoService.AlunoModel aluno) {
            return base.Channel.AdicionarAlunoAsync(aluno);
        }
        
        public DemoWCFSingleton.WebUI.AlunoService.AlunoModel[] ObterAlunos() {
            return base.Channel.ObterAlunos();
        }
        
        public System.Threading.Tasks.Task<DemoWCFSingleton.WebUI.AlunoService.AlunoModel[]> ObterAlunosAsync() {
            return base.Channel.ObterAlunosAsync();
        }
    }
}
