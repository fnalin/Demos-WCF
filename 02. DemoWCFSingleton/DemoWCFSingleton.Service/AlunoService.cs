using System.Collections.Generic;
using System.ServiceModel;

namespace DemoWCFSingleton.Service
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class AlunoService:IAlunoService
    {
        private readonly List<AlunoModel> _alunos;
        public AlunoService()
        {
            _alunos = new List<AlunoModel>();
        }

        public void AdicionarAluno(AlunoModel aluno)
        {
            _alunos.Add(new AlunoModel() { Nome = aluno.Nome, Cadastro = aluno.Cadastro });
        }

        public IList<AlunoModel> ObterAlunos()
        {
            return _alunos;
        }
    }
}
