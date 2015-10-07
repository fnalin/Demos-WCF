using System.Collections.Generic;
using System.ServiceModel;

namespace DemoHandlingExceptions.Service
{
    [ServiceContract]
    public interface IPacienteService
    {
        [OperationContract]
        Paciente Adicionar(Paciente paciente);
        [OperationContract]
        Paciente Editar(Paciente paciente);
        [OperationContract]
        bool Excluir(int id);
        [OperationContract]
        Paciente ObterPorID(int id);
        [OperationContract]
        IList<Paciente> ObterTodos();

    }
}
