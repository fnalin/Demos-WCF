using System.Collections.Generic;
using System.ServiceModel;

namespace DemosClient.Service
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class AniversarianteService : IAniversarianteService
    {
        private readonly IList<Aniversariante> _aniversariantes = new List<Aniversariante>();
        public void AddAniversariante(Aniversariante aniversariante)
        {
            _aniversariantes.Add(aniversariante);
        }

        public IList<Aniversariante> GetAniversariantes()
        {
            return _aniversariantes;
        }
    }
}
