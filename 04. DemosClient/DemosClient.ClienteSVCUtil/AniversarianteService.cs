﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemosClient.Service
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Aniversariante", Namespace="http://schemas.datacontract.org/2004/07/DemosClient.Service")]
    public partial class Aniversariante : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.DateTime DataField;
        
        private string NomeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Data
        {
            get
            {
                return this.DataField;
            }
            set
            {
                this.DataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome
        {
            get
            {
                return this.NomeField;
            }
            set
            {
                this.NomeField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IAniversarianteService")]
public interface IAniversarianteService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAniversarianteService/AddAniversariante", ReplyAction="http://tempuri.org/IAniversarianteService/AddAniversarianteResponse")]
    void AddAniversariante(DemosClient.Service.Aniversariante aniversariante);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAniversarianteService/AddAniversariante", ReplyAction="http://tempuri.org/IAniversarianteService/AddAniversarianteResponse")]
    System.Threading.Tasks.Task AddAniversarianteAsync(DemosClient.Service.Aniversariante aniversariante);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAniversarianteService/GetAniversariantes", ReplyAction="http://tempuri.org/IAniversarianteService/GetAniversariantesResponse")]
    DemosClient.Service.Aniversariante[] GetAniversariantes();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAniversarianteService/GetAniversariantes", ReplyAction="http://tempuri.org/IAniversarianteService/GetAniversariantesResponse")]
    System.Threading.Tasks.Task<DemosClient.Service.Aniversariante[]> GetAniversariantesAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IAniversarianteServiceChannel : IAniversarianteService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class AniversarianteServiceClient : System.ServiceModel.ClientBase<IAniversarianteService>, IAniversarianteService
{
    
    public AniversarianteServiceClient()
    {
    }
    
    public AniversarianteServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public AniversarianteServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public AniversarianteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public AniversarianteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public void AddAniversariante(DemosClient.Service.Aniversariante aniversariante)
    {
        base.Channel.AddAniversariante(aniversariante);
    }
    
    public System.Threading.Tasks.Task AddAniversarianteAsync(DemosClient.Service.Aniversariante aniversariante)
    {
        return base.Channel.AddAniversarianteAsync(aniversariante);
    }
    
    public DemosClient.Service.Aniversariante[] GetAniversariantes()
    {
        return base.Channel.GetAniversariantes();
    }
    
    public System.Threading.Tasks.Task<DemosClient.Service.Aniversariante[]> GetAniversariantesAsync()
    {
        return base.Channel.GetAniversariantesAsync();
    }
}
