using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace UsandoSelfHost.Service
{

    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public int Idade { get; set; }
    }

    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        void AddCliente(Cliente cli);
        [OperationContract]
        IList<Cliente> GetClientes();
    }

     [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ClienteService : IClienteService
    {
        private readonly IList<Cliente> _clientes = new List<Cliente>();

        public void AddCliente(Cliente cli)
        {
            _clientes.Add(cli);
        }

        public IList<Cliente> GetClientes()
        {
            return _clientes;
        }
    }
}
