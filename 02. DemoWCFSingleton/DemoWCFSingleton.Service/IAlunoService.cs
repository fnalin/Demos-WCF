using System.Collections.Generic;
using System.ServiceModel;

namespace DemoWCFSingleton.Service
{
    [ServiceContract]
    public interface IAlunoService
    {
        [OperationContract(IsOneWay = true)]
        void AdicionarAluno(AlunoModel aluno);
        [OperationContract]
        IList<AlunoModel> ObterAlunos();
    }
}
