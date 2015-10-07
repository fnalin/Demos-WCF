using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace DemoHandlingExceptions.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class PacienteService : IPacienteService
    {
        private readonly IList<Paciente> _pacientes;

        public PacienteService()
        {
            _pacientes = new List<Paciente> { 
                new Paciente{ID=1,Nome="Fabiano Nalin",Idade=36,Sexo=Sexo.Masculino},
                new Paciente{ID=2,Nome="Raphael Santos",Idade=16,Sexo=Sexo.Masculino},
                new Paciente{ID=3,Nome="Priscila Mitui",Idade=37,Sexo=Sexo.Feminino},
            };
        }

        public Paciente Adicionar(Paciente paciente)
        {
            paciente.ID = _pacientes.OrderByDescending(d => d.ID).First().ID + 1;
            _pacientes.Add(paciente);
            return paciente;
        }

        public Paciente Editar(Paciente paciente)
        {
            var pac = _pacientes.FirstOrDefault(d => d.ID == paciente.ID);
            pac.Nome = paciente.Nome;
            pac.Idade = paciente.Idade;
            pac.Sexo = paciente.Sexo;

            return pac;
        }

        public bool Excluir(int id)
        {
            throw new FaultException("Função desabilitada");
        }

        public Paciente ObterPorID(int id)
        {
            System.Threading.Thread.Sleep(3000);
            return _pacientes.FirstOrDefault(d => d.ID == id);
        }

        public IList<Paciente> ObterTodos()
        {
            return _pacientes;
        }
    }
}
