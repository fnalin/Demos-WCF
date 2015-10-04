using System.Collections.Generic;
using System.ServiceModel;

namespace DemosClient.Service
{
    [ServiceContract]
    public interface IAniversarianteService
    {
        [OperationContract]
        void AddAniversariante(Aniversariante aniversariante);
        [OperationContract]
        IList<Aniversariante> GetAniversariantes();
    }
}
